create database PRN221_asg1

CREATE TABLE Member (
    MemberId INT PRIMARY KEY,
    Email VARCHAR(100) NOT NULL,
    CompanyName VARCHAR(40),
    City VARCHAR(15),
    Country VARCHAR(15),
    Password VARCHAR(30) NOT NULL
);

CREATE TABLE [Order] (
    OrderId INT PRIMARY KEY,
    MemberId INT NOT NULL,
    OrderDate DATETIME NOT NULL,
    RequiredDate DATETIME,
    ShippedDate DATETIME,
    Freight MONEY,
    FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
);

CREATE TABLE Product (
    ProductId INT PRIMARY KEY,
    CategoryId INT,
    ProductName VARCHAR(40) NOT NULL,
    Weight VARCHAR(20),
    UnitPrice MONEY,
    UnitsInStock INT
);

CREATE TABLE OrderDetail (
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    UnitPrice MONEY NOT NULL,
    Quantity INT NOT NULL,
    Discount FLOAT,
    PRIMARY KEY (OrderId, ProductId),
    FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
    FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);
