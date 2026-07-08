Create Database PharmacyManagmentSystem;

CREATE TABLE Users (
    UserName VARCHAR(100),
	password VARCHAR(100),
);

CREATE TABLE Manager (
    ManagerName VARCHAR(100),
	password VARCHAR(100),
);

CREATE TABLE Medicine (
    MedName VARCHAR(100),
	MedType VARCHAR(100),
	MedPrice DECIMAL,
	MedQuantity INT
);

CREATE TABLE InvoiceItem (
    MedName VARCHAR(100),
	MedQuantity INT,
	MedPrice INT,
	Subtotal DECIMAL,
);

CREATE TABLE Invoice (
 CustomerName VARCHAR(100),
 ContactNo int,
 TotalItems int,
 TotalAmount decimal,
 InvoiceDate date,
 PaymentType VARCHAR(100)
);

INSERT INTO Users (UserName, password)
VALUES ('user', 'user');

INSERT INTO Manager (ManagerName, password)
VALUES ('admin', 'admin');

select * from Users;
select * from Manager;
select * from Medicine;
select * from InvoiceItem;
select * from Invoice;

DELETE from Users;
DELETE from Manager;
DELETE from Medicine;
DELETE from InvoiceItem;
DELETE from Invoice;