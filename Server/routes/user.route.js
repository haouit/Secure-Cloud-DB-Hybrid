const express = require('express');
const { usersDB } = require('../database');
const router = express.Router();

router.post('/login', (req, res) => {
	const { username, password } = req.body;
	if (!username || !password) {
		res.status(400).json({ error: 'Invalid request' });
		return;
	}
	usersDB.findOne({ username }, (err, user) => {
		if (err) {
			res.status(500).json({ error: 'Failed to find user' });
		} else {
			if (user && user.password === password) {
				res.status(200).json({ success: true });
			} else {
				res.status(401).json({ error: 'Invalid credentials' });
			}
		}
	});
});

router.post('/register', (req, res) => {
	const { username, password, email } = req.body;
	if (!username || !password || !email) {
		res.status(400).json({ error: 'Invalid request' });
		return;
	}
	const user = { username, password, email };
	usersDB.insert(user, (err, newDoc) => {
		if (err) {
			res.status(500).json({ error: 'Failed to register' });
		} else {
			res.status(200).json({ success: true, userId: newDoc._id });
		}
	});
	res.status(200).json({ success: true });
});

module.exports = router;
