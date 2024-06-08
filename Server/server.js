const express = require('express');
const Datastore = require('nedb');
const cors = require('cors');
const app = express();
const port = 3000;

const db = new Datastore({ filename: 'requests.db', autoload: true });
db.loadDatabase();

app.use(cors());
app.use(express.json());

/* 
Route to send a request from A to B
	- This route is used by A to send a request to B. The request contains A's public-key. 
	- The request is stored in the database with status 'pending'.
Request body: 
	{ from: 'A', to: 'B', message: 'B's public-key' }
Response: 
	{ success: true, requestId: 'id' }
*/
app.post('/send-request', (req, res) => {
    const { from, to, message } = req.body;
    const request = { from, to, message, status: 'pending' };

    db.insert(request, (err, newDoc) => {
        if (err) {
            res.status(500).json({ error: 'Failed to send request' });
        } else {
            res.status(200).json({ success: true, requestId: newDoc._id });
        }
    });
});

/*
Route to send a response from B to A
	- This route is used by B to send a response to A. The response may contain B's encrypted secret-key.
	- The request is updated in the database with the `message` and `response`.
Request body: 	
	{ from: 'A', to: 'B', message: 'A\'s encrypted secret-key', response: 'accepted' }
or	{ from: 'A', to: 'B', message: '', response: 'rejected' }
*/
app.post('/respond-request', (req, res) => {
    const { from, to, message, response } = req.body;

    db.update({ from, to, message }, { $set: { message, status: response } }, {}, (err, numReplaced) => {
        if (err) {
            res.status(500).json({ error: 'Failed to respond to request' });
        } else {
            res.status(200).json({ success: true });
        }
    });
});

/*
Route to check requests sent to B (called by itself)
	- This route is used by B to check all the requests sent to B.
	- The response contains all the requests with status 'pending'.
Request parameters: 
	:id - B's id
Response:
	[ docs ]
*/
app.get('/check-requests/:id', (req, res) => {
    const id = req.params.id;

    db.find({ to: id, status: 'pending' }, (err, docs) => {
        if (err) {
            res.status(500).json({ error: 'Failed to retrieve requests' });
        } else {
            res.status(200).json(docs);
        }
    });
});

/*
Route to check a request sent to B is accepted or rejected
	- This route is used by A to check if the request sent to B is accepted or rejected.
	- The response contains the status and message.
	- If the request is accepted, the message contains B's encrypted secret-key.
	- If the request is rejected, the message is empty.
Request body: 
	{ from: 'A', to: 'B' }
Response:
	{ status: 'accepted', message: 'A\'s encrypted secret-key' } 
or  { status: 'rejected' }
*/
app.get('/check-resopnse/', (req, res) => {
    const { from, to } = req.body;

    db.findOne({ from, to }, (err, doc) => {
        if (err || !doc) {
            res.status(404).json({ error: 'Request not found' });
        } else {
            res.status(200).json(doc);
        }
    });
});

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});
