const express = require('express');
const { requestsDB } = require('../database');
const router = express.Router();

/* 
Route to send a request from A to B
    - This route is used by A to send a request to B. The request contains A's public-key. 
    - The request is stored in the database with status 'pending'.
Request body: 
    { from: 'A', to: 'B', message: 'A's public-key' }
Response: 
    { success: true, requestId: 'id' }
*/
router.post('/send-request', (req, res) => {
    const { from, to, message } = req.body;
    if (!from || !to || !message) {
        return res.status(400).json({ error: 'Invalid request' });
    }
    const request = { from, to, message, status: 'pending' };

    requestsDB.insert(request, (err, newDoc) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to send request' });
        } else {
            return res.status(200).json({ success: true, requestId: newDoc._id });
        }
    });
});

/*
Route to send a response from B to A
    - This route is used by B to send a response to A. The response may contain B's encrypted secret-key.
    - The request is updated in the database with the `message` and `response`.
Request body: 	
    { from: 'A', to: 'B', message: 'B\'s encrypted secret-key', response: 'accepted' }
or	{ from: 'A', to: 'B', message: '', response: 'rejected' }
*/
router.post('/respond-request', (req, res) => {
    const { from, to, message, status } = req.body;

    requestsDB.update({ from, to }, { $set: { message, status } }, {}, (err) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to respond to request' });
        } else {
            return res.status(200).json({ success: true });
        }
    });
});

/*
Route to check requests sent to B (called by itself)
    - This route is used by B to check all the pending requests sent to B.
    - The response contains all the requests with status 'pending'.
Request parameters: 
    :id - B's id
Response:
    [ docs ] - a list of requests sent to B
*/
router.get('/check-requests/:id', (req, res) => {
    const id = req.params.id;

    requestsDB.find({ to: id, status: 'pending' }, (err, docs) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to retrieve requests' });
        } else {
            return res.status(200).json(docs);
        }
    });
});

/*
Route to check all requests sent from A to anyone is accepted or rejected
    - This route is used by A to check if the requests sent to any is accepted or rejected.
    - The response contains the list of responses (accepted or rejected)
Request body: 
    { from: 'A' }
Response:
    - a list of responed requests 
*/
router.post('/check-responses/', (req, res) => {
    const { from } = req.body;

    requestsDB.find({ from }, (err, docs) => {
        if (err || !docs) {
            return res.status(404).json({ error: 'Request not found' });
        } else {
            return res.status(200).json(docs);
        }
    });
});

module.exports = router;
