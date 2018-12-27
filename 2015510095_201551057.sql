CREATE TABLE [dbo].[Employee](
	[e_id] [int] IDENTITY(1,1) NOT NULL,
	[e_name] [nvarchar](50) NULL,
	[e_lname] [nvarchar](50) NULL,
	[e_salary] [int] NOT NULL,
	[e_bday] [date] NULL,
	[e_workdays] [nvarchar](9) NULL,/******S M T1 W T2 F S ********/
	[isPartTime] [nvarchar](10) NULL,
	[e_phone] [nvarchar](20) NULL,
	[e_mail] [nvarchar](45) NULL,
	[e_position] [nvarchar](15) NULL,
	[e_ssn] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[e_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Customer](
	[c_id] [int] IDENTITY(1,1) NOT NULL,
	[c_name] [nvarchar](50) NULL,
	[c_lname] [nvarchar](50) NULL,
	[c_phone] [nvarchar](20) NULL,
	[c_mail] [nvarchar](45) NULL,
	[c_ssn] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[Stock](
	[sto_id] [int] IDENTITY(1,1) NOT NULL,
	[sto_date] [date] NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [int] NOT NULL,
	[fromwhere] [nvarchar](50) NULL,
	[sto_name] [nvarchar](20)NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[sto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Car](
	[plate] [int] IDENTITY(1,1) NOT NULL,
	[c_id] [int] NOT NULL,
	[brand] [nvarchar](50) NULL,
	[model] [nvarchar](50)NOT NULL,
	[colour] [nvarchar](50) NULL,

	CONSTRAINT PK_Car PRIMARY KEY CLUSTERED (plate),     
	CONSTRAINT FK_Car_Owner FOREIGN KEY (c_id)     
    REFERENCES dbo.Customer (c_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE    
);


CREATE TABLE [dbo].[Service](
	[ser_id] [int] IDENTITY(1,1) NOT NULL,
	[est_time] [nvarchar](50) NULL,
	[ser_name] [nvarchar](50)NOT NULL,
	[tax_rate] [int] NOT NULL,
	[ser_price] [int] NOT NULL,

	CONSTRAINT PK_Service PRIMARY KEY CLUSTERED (ser_id)  
	/*,  
	CONSTRAINT FK_Used_Stock FOREIGN KEY (sto_id)     
    REFERENCES dbo.Stock (sto_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE    
*/

);

CREATE TABLE [dbo].[InService](
	[inS_id] [int] IDENTITY(1,1) NOT NULL,
	[plate] [int] NOT NULL,
	/*[ser_id] [int] NOT NULL,*/
	[status] [nvarchar](50) NOT NULL,
	CONSTRAINT PK_InService PRIMARY KEY CLUSTERED (inS_id),     
	CONSTRAINT FK_Car FOREIGN KEY (plate)     
    REFERENCES dbo.Car (plate)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,
	/*
	CONSTRAINT FK_Ins_Used_Service FOREIGN KEY (ser_id)     
    REFERENCES dbo.[Service] (ser_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE
	*/
);
CREATE TABLE [dbo].[Bill](
	[b_id] [int] NOT NULL,
	[c_id] [int] NOT NULL,
	/*[ser_id] [int] NOT NULL,*/
	/*[e_id] [int] NOT NULL,*/
	[cur_date] [date]NOT NULL,
	CONSTRAINT PK_Bill PRIMARY KEY CLUSTERED (b_id),     
	CONSTRAINT FK_Bill_Customer FOREIGN KEY (c_id)     
    REFERENCES dbo.Customer (c_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,
	/*CONSTRAINT FK_Bill_Used_Service FOREIGN KEY (ser_id)     
    REFERENCES dbo.[Service] (ser_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,
	*/
	/*
	CONSTRAINT FK_Worked_Employee FOREIGN KEY (e_id)     
    REFERENCES dbo.Employee (e_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE
	*/
);


/********************* 1NF ----- ADDITIONAL TABLES *********************/

CREATE TABLE [dbo].[Stocks_Used_In_Services](
	[suis] [int] IDENTITY(1,1) NOT NULL,/* SUIS = Stocks Used In Services*/ 
	[ser_id] [int] NOT NULL,
	[sto_id] [int] NOT NULL,

	CONSTRAINT PK_SUIS PRIMARY KEY CLUSTERED (suis),     
	CONSTRAINT FK_SUIS_Service FOREIGN KEY (ser_id)     
    REFERENCES dbo.[Service] (ser_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,  
	CONSTRAINT FK_SUIS_Stock FOREIGN KEY (sto_id)     
    REFERENCES dbo.Stock (sto_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,        
);

CREATE TABLE [dbo].[Services_Used_In_Bill](
	[suib] [int] IDENTITY(1,1) NOT NULL,/* SUIB = Services Used In Bill*/ 
	[b_id] [int] NOT NULL,
	[ser_id] [int] NOT NULL,

	CONSTRAINT PK_SUIB PRIMARY KEY CLUSTERED (suib),     
	CONSTRAINT FK_SUIB_Service FOREIGN KEY (ser_id)     
    REFERENCES dbo.[Service] (ser_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,  
	CONSTRAINT FK_SUIB_Bill FOREIGN KEY (b_id)     
    REFERENCES dbo.Bill (b_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,        
);

CREATE TABLE [dbo].[Employees_Used_In_Bill](
	[euib] [int] IDENTITY(1,1) NOT NULL,/* EUIB = Employees Used In Bill*/ 
	[b_id] [int] NOT NULL,
	[e_id] [int] NOT NULL,

	CONSTRAINT PK_EUIB PRIMARY KEY CLUSTERED (euib),     
	CONSTRAINT FK_EUIB_Employee FOREIGN KEY (e_id)     
    REFERENCES dbo.[Employee] (e_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,  
	CONSTRAINT FK_EUIB_Bill FOREIGN KEY (b_id)     
    REFERENCES dbo.Bill (b_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,        
);

CREATE TABLE [dbo].[Services_Used_In_Inservice](
	[suii] [int] IDENTITY(1,1) NOT NULL,/* SUII = Services Used In Inservice*/ 
	[inS_id] [int] NOT NULL,
	[ser_id] [int] NOT NULL,

	CONSTRAINT PK_SUII PRIMARY KEY CLUSTERED (suii),     
	CONSTRAINT FK_SUII_Service FOREIGN KEY (ser_id)     
    REFERENCES dbo.[Service] (ser_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,  
	CONSTRAINT FK_SUII_Inservice FOREIGN KEY (inS_id)     
    REFERENCES dbo.Inservice (inS_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,        
);
/****************      END OF 1NF      ************************/

CREATE TABLE logs(
[log_id] int IDENTITY(1,1) not null,
[log_data] nvarchar(256),
[log_date] date,
CONSTRAINT PK_LOG PRIMARY KEY CLUSTERED (log_id), 

);


go

/* getting logs*/
create PROCEDURE spSelectLogs
as

SELECT
 [Transaction ID],
 [Operation],
  [Transaction Name],
 [CONTEXT],
 [AllocUnitName],
 [Page ID],
 [Slot ID],
 [Begin Time],
 [End Time]
FROM sys.fn_dblog(NULL,NULL)
WHERE Operation IN 
   ('LOP_INSERT_ROWS','LOP_MODIFY_ROW',
    'LOP_DELETE_ROWS','LOP_BEGIN_XACT','LOP_COMMIT_XACT') 
	
GO

/* trigger*/
ALTER TRIGGER trigger_employee
ON Employee AFTER DELETE 
AS
Begin
DECLARE @CNT INT
SELECT @CNT = COUNT(*) FROM Employee
IF(@CNT=0)
BEGIN 
INSERT INTO dbo.Employee VALUES('Onur','Kantar','1606','','','yes','05347760010','onur.kantar@ceng.deu.edu.tr','CEO','35327127134')
END
End

/****************      Stored Procedures      ************************/
Go;
CREATE PROCEDURE spSelectEmployee
AS
SELECT * FROM Employee
GO

CREATE PROCEDURE sp_GetEmployeeByID @id int
AS
BEGIN
SELECT * FROM Employee WHERE e_id = @id
END
GO


CREATE PROCEDURE SP_InsertEmployee @NAME nvarchar(50), @SURNAME nvarchar(50), @SALARY int, @ISPARTTIME nvarchar(20)  ,@PHONE nvarchar(20), @MAIL nvarchar(45), @POSITION nvarchar(15), @WORKDAYS nvarchar(50), @SSN nvarchar(20) , @BIRTHDAY date
AS
begin
INSERT into dbo.Employee (e_name,e_lname,e_salary,e_bday,e_workdays,isPartTime,e_phone,e_mail,e_position,e_ssn) VALUES(@NAME,@SURNAME,@SALARY,@BIRTHDAY,@WORKDAYS,@ISPARTTIME,@PHONE,@MAIL,@POSITION,@SSN)
end	
GO



CREATE PROCEDURE SP_DeleteEmployee @ID int
as
delete Employee where 'e_id' = @ID
go

Create procedure SP_UpdateEmployee @ID int , @NAME nvarchar(50), @SURNAME nvarchar(50), @SALARY int, @ISPARTTIME nvarchar(20)  ,@PHONE nvarchar(20), @MAIL nvarchar(45), @POSITION nvarchar(15), @WORKDAYS nvarchar(50), @SSN nvarchar(20) , @BIRTHDAY date
AS
UPDATE Employee
SET "e_name" = @NAME, "e_lname" = @SURNAME, "e_salary" = @SALARY , "e_bday" = @BIRTHDAY , "e_workdays" = @WORKDAYS , "isPartTime" = @ISPARTTIME , "e_phone" = @PHONE , "e_mail" = @MAIL , "e_position" = @POSITION , "e_ssn" = @SSN
WHERE 'e_id' = @ID;
go

/* end of employee part */

CREATE PROCEDURE spSelectCustomer
AS
SELECT * FROM Customer
go

CREATE PROCEDURE SP_InsertCustomer @NAME nvarchar(50), @SURNAME nvarchar(50),@PHONE nvarchar(20), @MAIL nvarchar(45), @SSN nvarchar(20)
AS
begin
INSERT into dbo.Customer VALUES(@NAME,@SURNAME,@PHONE,@MAIL,@SSN)
end	
go

CREATE PROCEDURE SP_DeleteCustomer @ID int
as
delete Customer where c_id = @ID
go

CREATE PROCEDURE sp_GetCustomerByID @id int
AS
BEGIN
SELECT * FROM Customer WHERE c_id = @id
END
GO

CREATE procedure SP_UpdateCustomer @ID int , @NAME nvarchar(50), @SURNAME nvarchar(50), @PHONE nvarchar(20), @MAIL nvarchar(45), @SSN nvarchar(20)
AS
UPDATE Customer
SET "c_name" = @NAME, "c_lname" = @SURNAME, "c_phone" = @PHONE , "c_mail" = @MAIL , "c_ssn" = @SSN
WHERE c_id = @ID;
go
/*end of customer part*/

CREATE PROCEDURE spSelectStock
AS
SELECT * FROM Stock
go

CREATE PROCEDURE sp_GetStockByID @id int
AS
BEGIN
SELECT * FROM Stock WHERE sto_id = @id
END
GO

CREATE PROCEDURE SP_InsertStock @STODATE date,@QUANTITY int,@PRICE int,@FROMWHERE nvarchar(50),@STONAME nvarchar(20)
AS
begin
INSERT into dbo.Stock VALUES(@STODATE,@QUANTITY,@PRICE,@FROMWHERE,@STONAME)
end	
go


CREATE procedure SP_UpdateStock @ID int , @STODATE date,@QUANTITY int,@PRICE int,@FROMWHERE nvarchar(50),@STONAME nvarchar(20)
AS
UPDATE Stock
SET "sto_date" = @STODATE, "quantity" = @QUANTITY, "price" = @PRICE , "fromwhere" = @FROMWHERE, "sto_name" = @STONAME
WHERE sto_id = @ID;
go

CREATE PROCEDURE SP_DeleteStock @ID int
as
delete Stock where sto_id = @ID
go
/*end of stock part*/