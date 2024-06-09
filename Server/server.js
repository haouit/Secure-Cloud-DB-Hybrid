const express = require('express');
const cors = require('cors');
const app = express();
const port = 3000;

const communicateRouter = require('./routes/communicate.route');
const userRouter = require('./routes/user.route');
const dataRouter = require('./routes/data.route');
const bodyParser = require('body-parser');

// Middleware
app.use(cors());
app.use(express.json());
app.use(bodyParser.json({limit: '50mb'}));
app.use(bodyParser.urlencoded({limit: "50mb", extended: true, parameterLimit:50000}));
// Routes 
app.use('/api/user', userRouter);
app.use('/api/communicate', communicateRouter);
app.use('/api/data', dataRouter);

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});
