# Databases Overview Homework
### Telerik-Academy-2016

1.  What database models do you know?
    * Relational Database Model 
        * Tables with relationships between them (MSSQL)
    * Non-Relational Database Model
        * Document model (MongoDb)
        * Key-value model (Redis)
        * Hierarchical key-value
        * Object model
1.  Which are the main functions performed by a Relational Database Management System (RDBMS)?
    * RDBMS manage data stored in tables
    * RDBMS implements
        * Creating, deleting and relationships between tables
        * Adding, deleting, searching and chaining data in tables
        * Support for SQL
    * Popular RDBMS Systems
        * Microsoft SQL Server
        * MySQL
        * Oracle Database
1.  Define what is "table" in database terms.
    * In database tables consist of information stored in rows and columns. Collumns have name and types. Rows all have the same structure.
1.  Explain the difference between a primary and a foreign key.
    * Primary key is a column of the table that identifies its rows by unique identifier (usually number). Two rows of the table are different if their primary key is different.
        * In some cases primary key can be composed of more than one column
    * The foreign key is an identifier of a record, that is located in a different table (usually its primary key) 
1.  Explain the different kinds of relationships between tables in relational databases.
    * One-to-many
        * A single record in the first table has many corresponding records in the second table. (Ex. cities and countries)
    * Many-to-many
        * Records in the first table have many corresponding records in the second table and vise versa. Can be implemented by additional table
    * One-to-one
        * Single record in one table corresponds with single record in the second table. Usually reffered as table inheritance.
1.  When is a certain database schema normalized?
    * Database schema is normalized when there is no repeating data.
1.  What are database integrity constraints and when are they used?
    * Ensures that the information in the database cannot be violated. Enforces data rules. (Ex. Primary key has always different value for each row)
        * Ensures data validation
1.  Point out the pros and cons of using indexes in a database.
    * Pros - very high speed when searching of values in a certain column or group of columns
    * Cons - adding and deleting records in indexed table is slow. Indexed tables must be used only for big databases.
1.  What's the main purpose of the SQL language?
    * The main purpose of the SQL language is to crate, altere, delete, search, insert and modify data in the table.
1.  What are transactions used for?
    * Transacations are sequence of database operations which are executed as single unit. Only if all operation are successful the transaction is executed
        * Usage example - money related databases (bank withdraw)
1.  What is a NoSQL database?
    * Non-Relational databases. They use document model.
1.  Explain the classical non-relational data models.
    * Data is stored as documents
    * Single entity is a single document
    * Does not have fixed strucutre
1.  Give few examples of NoSQL databases and their pros and cons.
    * Key-value (KV) stores use the associative array as their fundamental data model. In this model, data is represented as a collection of key-value pairs, such that each possible key appears at most once in the collection.Key-value stores can use consistency models ranging from eventual consistency to serializability. Some databases support ordering of keys. There are various hardware implementations, and some users maintain data in memory (RAM), while others employ solid-state drives or rotating disks. (Oracle database)
    * Document model - The central concept of a document store is the notion of a "document". While each document-oriented database implementation differs on the details of this definition, in general, they all assume that documents encapsulate and encode data in some standard formats or encodings. Encodings in use include XML, YAML, and JSON as well as binary forms like BSON. Documents are addressed in the database via a unique key that represents that document. One of the other defining characteristics of a document-oriented database is that in addition to the key lookup performed by a key-value store, the database offers an API or query language that retrieves documents based on their contents.