const express = require('express');
const { datasDB } = require('../database');
const router = express.Router();

router.post('/upload-data', (req, res) => {
    const { from, name, message } = req.body;
    if (!from || !name || message) {
        return res.status(400).json({ error: 'Invalid data' });
    }
    const data = { from, name, message };

    datasDB.insert(data, (err, newDoc) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to send request' });
        } else {
            console.log('Upload data:', { from, name });
            return res.status(200).json({ success: true, dataId: newDoc._id });
        }
    });
});

router.post('/remove-data', (req, res) => {
    const { from, name, message } = req.body;

    datasDB.remove({ from, name, message }, {}, (err) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to remove data' });
        } else {
            console.log('Remove data:', { from, name });
            return res.status(200).json({ success: true });
        }
    });

});

router.get('/data-all', (req, res) => {
    datasDB.find({}, (err, docs) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to retrieve data' });
        } else {
            console.log('Data all');
            return res.status(200).json(docs);
        }
    });
});

exports.router = router;