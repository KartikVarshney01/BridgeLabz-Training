-- DDL – Data Definition Language
---- Used to define and modify structure of database objects like tables.

--- Create Database
--- Syntax : CREATE DATABASE database_name;
CREATE DATABASE BridgeLabz;

--- USE : USE specifies which database the subsequent SQL commands will run on.
--- Syntax : USE database_name;
USE BridgeLabz;

--- Using Create To Creates a new table, view, or database.
--- -- Create Table
--- Syntax : CREATE TABLE table_name (column1 datatype [constraint],column2 datatype [constraint],);
CREATE TABLE Students(
	ID INT PRIMARY KEY,
	Name VARCHAR(100)
);

-- Select all
--- Syntax : SELECT * FROM table_name;

-- Select specific columns
--- Syntax : SELECT col1, col2 FROM table_name;

-- With condition
--- Syntax : SELECT * FROM table_name WHERE condition;
Select * From Students;

------------------------------------------------------------------
--- ALTER : Modifies an existing table (add/delete columns, etc.).
--- Add Column
--- Syntax : ALTER TABLE table_name
--- ADD column_name datatype;

--- Modify Column
--- Syntax : ALTER TABLE table_name
--- ALTER COLUMN column_name new_datatype;

--- Drop Column
--- Syntax : ALTER TABLE table_name
--- DROP COLUMN column_name;
------------------------------------------------------------------

ALTER TABLE Students ADD Age INT;

SELECT * FROM Students;

--- TRUNCATE : Removes all records from a table (cannot be rolled back).
--- Syntax : TRUNCATE TABLE table_name;

TRUNCATE TABLE Students;

--- DROP : Deletes a table or database.
--- Drop Table
--- Syntax : DROP TABLE table_name;
--- Drop Database
--- Syntax : DROP DATABASE database_name;

DROP TABLE Students;

---------------------------------------------------------

-------------DML------------

-- DML – Data Manipulation Language
---- Used to manage data inside tables.

-------------------------------------------------------------
--- INSERT : Adds new records.
--- Syntax : Insert single record
--- INSERT INTO table_name (col1, col2)
--- VALUES (value1, value2);

--- Insert multiple records
--- Syntax : INSERT INTO table_name
--- VALUES
--- (value1, value2),
--- (value3, value4);
---------------------------------------------------------------

INSERT INTO Students(ID, Name, Age) VALUES 
	(1, 'Arjun', 20),
	(2, 'Kartik', 25);

----------------------------------------------------------------
--- UPDATE : Modifies existing records.
--- Syntax : UPDATE table_name
--- SET column1 = value1
--- WHERE condition;
----------------------------------------------------------------

UPDATE Students SET Age = 21 WHERE ID = 1;

Select * From Students;

--------------------------------------------------------------
--- DELETE : Removes specific records.
--- Syntax : DELETE FROM table_name WHERE condition;
---------------------------------------------------------------

DELETE FROM Students WHERE ID = 1;

-------------------------------------------------------------

----------DQL-----------

--- DQL – Data Query Language
--- Used for querying data.
--- Select : Retrieves data from one or more tables.

SELECT * FROM Students;
SELECT Name, Age FROM Students WHERE Age > 18;

---------------------------------------------------------------------
----------------TCL-----------------

--- TCL – Transaction Control Language
--- Used to manage transactions in a database.

--- BEGIN : BEGIN has two common uses:
--- 1. BEGIN TRANSACTION -> starts a transaction
--- 2. BEGIN … END -> groups multiple SQL statements

BEGIN Transaction;
UPDATE Students SET Age = 25 WHERE ID = 2;

--- SAVEPOINT : Sets a save point within a transaction.
--- Syntax : SAVE TRANSACTION savepoint_name;

SAVE TRANSACTION sp1;

UPDATE Students SET Age = 30 WHERE ID = 2;

--- ROLLBACK : Undoes changes since last commit.
--- Syntax : ROLLBACK TRANSACTION savepoint_name
ROLLBACK TRANSACTION sp1;

--- COMMIT : Saves all changes made.
--- Syntax : COMMIT

COMMIT;
---------------------------------------------------------------------

----------DCL------------

--- DCL – Data Control Language
--- Used to control access/permissions.

-- DCL – Data Control Language

USE master;

GO
-- CREATE LOGIN <LoginName> WITH PASSWORD = '<Password>';
CREATE LOGIN Kartik WITH PASSWORD = '123';
CREATE LOGIN Satyam WITH PASSWORD = '123';
GO

USE BridgeLabz;

GO
-- CREATE USER <UserName> FOR LOGIN <LoginName>;
CREATE USER UserKartik FOR LOGIN Kartik;
CREATE USER UserSatyam FOR LOGIN Satyam; 
GO

--- GRANT : Gives user access privileges.
--- Syntax : GRANT permission ON object_name TO user_name;

GRANT SELECT ON Students TO UserKartik;

--- Synatx : REVOKE permission ON object_name FROM user_name;
--- REVOKE : Removes user privileges.

REVOKE SELECT ON Students FROM UserSatyam;

---------------------------------------------------------------------


