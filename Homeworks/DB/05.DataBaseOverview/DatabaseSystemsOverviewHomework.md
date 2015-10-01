## Database Systems - Overview - Homework

### 1.  What database models do you know?

A database model is a type of data model that determines the logical structure of a database and fundamentally determines in which manner data can be stored, organized, and manipulated. The most popular example of a database model is the relational model, which uses a table-based format.

##### Logical data models:

* Hierarchical database model (tree)
* Network model (graph)
* Relational model (table)
* Object-oriented model
* Entity–relationship model
* Enhanced entity–relationship model
* Document model
* Entity–attribute–value model
* Star schema

##### Physical data models:

* Inverted index
* Flat file

##### Other models:

* Associative model
* Multidimensional model

### 2.  Which are the main functions performed by a Relational Database Management System (RDBMS)?

A relational database management system (RDBMS) is a database management system (DBMS) that is based on the relational model 

RDBMS systems typically implement
* Creating / altering / deleting tables and relationships between them (database schema)
* Adding, changing, deleting, searching and retrieving of data stored in the tables
* Support for the SQL language
* Transaction management (optional)

### 3.  Define what is "table" in database terms.

A database table is a collection of related data held in a structured format within a database. It consists of columns and rows.
In relational databases a table is a set of data elements (values) using a model of:
* vertical columns
* horizontal rows
* and the cell being the unit where a row and column intersect.

### 4.  Explain the difference between a primary and a foreign key.

In SQL Server, there are two keys - primary key and foreign key which seems identical, but actually both are different in features and behaviours. 

Primary Key | Foreign Key
-----------------------------------------------------|-----------------------------------------------------
Primary key uniquely identify a record in the table. | Foreign key is a field in the table that is primary key in another table.
Primary Key can't accept null values. | Foreign key can accept multiple null value.
By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index. | Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
We can have only one Primary key in a table. | We can have more than one foreign key in a table.   

### 5.  Explain the different kinds of relationships between tables in relational databases.

A relationship, in the context of databases, is a situation that exists between two relational database tables when one table has a foreign key that references the primary key of the other table. Relationships allow relational databases to split and store data in different tables, while linking disparate data items.

The relationships between tables are based on interconnections: primary key / foreign key. The foreign key is an identifier of a record located in another table (usually its primary key).

Three types of relationships can exist between tables in a database: _one-to-many_, _one-to-one_, and _many-to-many_.

##### One-to-many
A one-to-many relationship is by far the most common type of relationship. In a one-to-many relationship, a record in one table can have many related records in another table. The primary key table contains only one record that relates to none, one, or many records in the related table.

##### Many-to-many
In a many-to-many relationship, records in both tables have matching records in the other table. Each primary key value relates to only one (or no) record in the related table. These relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.

##### One-to-one
In a one-to-one relationship, each record in the table on the one side of the relationship can have only one matching record in the table on the many side of the relationship. Each primary key value relates to only one (or no) record in the related table. This relationship is not common and is used only in special circumstances.
This kind of relationship is like Inheritance in OOP.

_Examples:_

![Relationships](http://fms-itskills.ncl.ac.uk/db/ER.png)

##### Self relationship (ïðèìêà)
This is used when a table needs to have a relationship with itself. The primary / foreign key relationships can point to one and the same table.

Example: employees in a company have a manager, who is also an employee.

![Self-relationship](http://docs.telerik.com/data-access/images/developer-guide-domain-model-naming-settings-nav-props-names-handling-selfref-1m-010.png)

### 6.  When is a certain database schema normalized?

A database schema is a way to logically group objects such as tables, views, stored procedures etc. Think of a schema as a container of objects.
The relational schema describes the structure of the database. Doesn't contain data, but metadata.

Database normalization is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy.
Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones.

Advantages  | Disadvantages
----------------------------|----------------------------
Smaller database: by eliminating duplicate data. | More tables to join: by spreading data into more tables.
Better performance. | FTables contain codes instead of real data.

### 7.  What are database integrity constraints and when are they used?
### 8.  Point out the pros and cons of using indexes in a database.
### 9.  What's the main purpose of the SQL language?
### 10.  What are transactions used for?
  * Give an example.

### 11.  What is a NoSQL database?
### 12.  Explain the classical non-relational data models.
### 13.  Give few examples of NoSQL databases and their pros and cons.
