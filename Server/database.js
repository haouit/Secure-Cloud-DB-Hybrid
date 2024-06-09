const Datastore = require('nedb');

// Database for storing requests
const requestsDB = new Datastore({ filename: 'databases/requests.db', autoload: true });
requestsDB.loadDatabase();

const usersDB = new Datastore({ filename: 'databases/users.db', autoload: true });
usersDB.loadDatabase();

const filesDB = new Datastore({ filename: 'databases/files.db', autoload: true });
filesDB.loadDatabase();

module.exports = {
	requestsDB,
	usersDB,
	filesDB
};