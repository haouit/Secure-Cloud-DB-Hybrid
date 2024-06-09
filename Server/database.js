const Datastore = require('nedb');

// Database for storing requests
const requestsDB = new Datastore({ filename: 'databases/requests.db', autoload: true });
requestsDB.loadDatabase();

const usersDB = new Datastore({ filename: 'databases/users.db', autoload: true });
usersDB.loadDatabase();

const datasDB = new Datastore({ filename: 'databases/datas.db', autoload: true });
datasDB.loadDatabase();

module.exports = {
	requestsDB,
	usersDB,
	datasDB
};