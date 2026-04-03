USE master;
USE BridgeLabz;

select * FROM Students;

------------- STORED PROCEDURE --------------
---- A Stored Procedure is a precompiled collection of T-SQL statements stored in the database that can be executed using a command.

--- 1.Procedure Without Parameters
--- Syntax : CREATE PROCEDURE ProcedureName
---          AS
---          BEGIN
---             SQL statements;
---          END;

--- Execution - EXEC ProcedureName;

INSERT INTO Students (ID,Name,Age) 
Values 
(1,'Harsh',20),
(3,'Satyam',18);

GO
CREATE PROCEDURE SPGetAllStudents
AS
BEGIN
SELECT * FROM Students;
END;

EXEC SPGetAllStudents

--- 2. Procedure With Input Parameters
--- Syntax : CREATE PROCEDURE ProcedureName
---          @Parameter1 DataType,
---          @Parameter2 DataType
---			 AS
---			 BEGIN
---				SQL statements using parameters;
---			 END;

--- Execution - EXEC ProcedureName value1, value2;
GO
CREATE PROCEDURE SPGetStudentsByID
@ID INT
AS
BEGIN
SELECT * FROM Students WHERE ID = @ID;
END;

EXEC SPGetStudentsByID 1;

--- Add Student 
GO
CREATE PROCEDURE SPAdd_Student(@ID INT,@Name VARCHAR(20),@Age INT)
As
BEGIN
    INSERT INTO Students Values(@ID,@Name,@Age);
END

EXEC SPAdd_Student 4,'Aryan',22;
EXEC SPAdd_Student 5,'Yash',23;
EXEC SPAdd_Student 6,'Aditya',26;

--- Delete Student
GO
CREATE PROCEDURE SPDelete_Student
@ID INT
As
BEGIN
    DELETE FROM Students Where ID = @ID;
END;

EXEC SPDelete_Student 6;

--- 3. Procedure With OUTPUT Parameter
--- Syntax : CREATE PROCEDURE ProcedureName
---		     @Parameter DataType OUTPUT
---			 AS
---			 BEGIN
---		     SELECT @Parameter = expression;
---			 END;

--- Execution - DECLARE @Var DataType;
---				EXEC ProcedureName @Var OUTPUT;
---				PRINT @Var;

GO
CREATE PROCEDURE SPGet_Students_Age_By_ID
@ID INT,
@Age INT OUTPUT
AS
BEGIN
	SELECT @Age = Age From Students Where ID = @ID;
END;

GO
DECLARE @StudentAge INT;

EXEC SPGet_Students_Age_By_ID
    @ID = 1,
    @Age = @StudentAge OUTPUT;

PRINT @StudentAge;


--- 4. Procedure With IF-ELSE
--- Syntax : CREATE PROCEDURE ProcedureName
---          @Value INT
---          AS
---          BEGIN
---             IF @Value > 18
---                 PRINT 'Eligible';
---             ELSE
---                 PRINT 'Not Eligible';
---          END;

--- Execution - EXEC ProcedureName @Value

--- ADD Student With Checking If Already Exists or Not
GO
CREATE PROCEDURE SPAdd_Student_Check(@ID INT,@Name VARCHAR(20),@Age INT)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Students WHERE ID = @ID)
        PRINT 'Student Already Exists'
    ELSE
        INSERT INTO Students Values (@ID,@Name,@Age);
END;

EXEC SPAdd_Student_Check 5,'Kartik',26;

--- Update Student 
GO
CREATE PROCEDURE SPUpdate_Student
@ID INT,
@Age INT
AS
BEGIN
    UPDATE Students
    SET Age = @Age
    WHERE ID = @ID;
END;




------------ TRIGGER ---------------
--- A Trigger is a special stored procedure that automatically executes when an INSERT, UPDATE, or DELETE happens on a table.

--- Syntax : CREATE TRIGGER TriggerName
---          ON TableName
---          AFTER | INSTEAD OF INSERT | UPDATE | DELETE
---          AS
---          BEGIN
---             -- Trigger logic
---          END;

GO
CREATE TRIGGER TRGAfterInsert_Students
ON Students
AFTER INSERT
AS
BEGIN
    PRINT 'Student record inserted';
END;

EXEC SPAdd_Student_Check 7,'Yash',26;

