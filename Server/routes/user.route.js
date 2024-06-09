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
			return res.status(500).json({ error: 'Failed to find user' });
		} else {
			if (user && user.password === password) {
				console.log('[User] logged in:', user);
				return res.status(200).json({ success: true });
			} else {
				return res.status(401).json({ error: 'Invalid credentials' });
			}
		}
	});
});

router.post('/register', (req, res) => {
	const { username, password, email } = req.body;
	if (!username || !password || !email) {
		return res.status(400).json({ error: 'Invalid request' });
	}
	const user = { username, password, email };
	usersDB.insert(user, (err, newDoc) => {
		if (err) {
			return res.status(500).json({ error: 'Failed to register' });
		} else {
			console.log('[User] registered:', user.username);
			return res.status(200).json({ success: true, userId: newDoc._id });
		}
	});
	return res.status(200).json({ success: true });
});

module.exports = router;
