const express = require('express');
const cors = require('cors');
const app = express();
const port = 3000;

const communicateRouter = require('./routes/communicate.route');
const userRouter = require('./routes/user.route');

// Middleware
app.use(cors());
app.use(express.json());

// Routes 
app.use('/api/user', userRouter);
app.use('/api/communicate', communicateRouter);

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});