const express = require('express');
const { filesDB } = require('../database');
const router = express.Router();

router.post('/upload-data', (req, res) => {
    const { author, filename, content } = req.body;
    if (!author || !filename || !content) {
        return res.status(400).json({ error: 'Invalid data' });
    }
    const data = { author, filename, content };
    filesDB.insert(data, (err, newDoc) => {
        if (err) {
            console.log(err);
            return res.status(500).json({ error: 'Failed to send request' });
        } else {
            console.log('Upload data:', { author, filename });
            return res.status(200).json({ success: true, dataId: newDoc._id });
        }
    });
    return;
});

router.post('/remove-data', (req, res) => {
    const { author, filename } = req.body;

    filesDB.remove({ author, filename }, {}, (err) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to remove data' });
        } else {
            console.log('Remove data:', { author, filename });
            return res.status(200).json({ success: true });
        }
    });
    return;
});

router.get('/all/:user', (req, res) => {
    const { user } = req.params;
    if (!user) {
        return res.status(400).json({ error: 'Invalid user' });
    }
    filesDB.find({ author: user }, (err, docs) => {
        if (err) {
            return res.status(500).json({ error: 'Failed to retrieve data' });
        } else {
            console.log('Data all');
            return res.status(200).json(docs);
        }
    });
    return;
});

module.exports = router;
