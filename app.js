var express = require('express');
var path = require('path');

var rootRouter = require('./routes/index.route');

var app = express();

// view engine setup
app.set('view engine', 'ejs');

// route setup
app.use('/', rootRouter);

app.listen(8888, function() {
	console.log('Server is running on port 8888');
});