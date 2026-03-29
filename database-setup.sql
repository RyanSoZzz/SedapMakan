/*
    Restaurant Management System - Database Setup
    -------------------------------------------------
    This script creates the ioopass database, defines the schema,
    and inserts sample data for testing/demo purposes.

    Recommended usage:
    1. Open in SQL Server Management Studio.
    2. Run the full script.
    3. Update the app connection string if your SQL Server instance name differs.
*/

USE master;
GO

IF DB_ID('ioopass') IS NOT NULL
BEGIN
    ALTER DATABASE ioopass SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE ioopass;
END
GO

CREATE DATABASE ioopass;
GO

USE ioopass;
GO

/* =========================
   TABLES
   ========================= */

CREATE TABLE Account (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10),
    PhoneNumber BIGINT
);
GO

CREATE TABLE Role (
    RoleID NVARCHAR(10) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE AccountRoles (
    AccID INT NOT NULL,
    RoleID NVARCHAR(10) NOT NULL,
    Salary DECIMAL(10,2) NULL,
    LastAccessed DATE NULL,
    CONSTRAINT PK_AccountRoles PRIMARY KEY (AccID, RoleID),
    CONSTRAINT FK_AccountRoles_Account FOREIGN KEY (AccID) REFERENCES Account(AccountID),
    CONSTRAINT FK_AccountRoles_Role FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
);
GO

CREATE TABLE Admin (
    AdminID NVARCHAR(50) PRIMARY KEY,
    AccountID INT NOT NULL,
    CONSTRAINT FK_Admin_Account FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);
GO

CREATE TABLE Manager (
    ManagerID NVARCHAR(50) PRIMARY KEY,
    AccountID INT NOT NULL,
    CONSTRAINT FK_Manager_Account FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);
GO

CREATE TABLE Chef (
    ChefID NVARCHAR(50) PRIMARY KEY,
    AccountID INT NOT NULL,
    CONSTRAINT FK_Chef_Account FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);
GO

CREATE TABLE Customer (
    CustomerID NVARCHAR(50) PRIMARY KEY,
    AccountID INT NOT NULL,
    CONSTRAINT FK_Customer_Account FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);
GO

CREATE TABLE Menus (
    MenuID NVARCHAR(50) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(10,2),
    Category NVARCHAR(50) CHECK (Category IN ('Vegetarian', 'Italian', 'Mexican', 'Local', 'Drinks')),
    Availability NVARCHAR(20) CHECK (Availability IN ('Available', 'Unavailable')),
    Duration INT,
    Image_url NVARCHAR(255)
);
GO

CREATE TABLE [Order] (
    OrderID NVARCHAR(50) PRIMARY KEY,
    ChefID NVARCHAR(50) NULL,
    CustomerID NVARCHAR(50) NOT NULL,
    TotalOrderFee DECIMAL(10,2),
    [Date] DATE,
    Status NVARCHAR(50) CHECK (Status IN ('Completed', 'In Progress', 'Failed')),
    CONSTRAINT FK_Order_Chef FOREIGN KEY (ChefID) REFERENCES Chef(ChefID),
    CONSTRAINT FK_Order_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
GO

CREATE TABLE OrderItem (
    OrderItemID NVARCHAR(50) PRIMARY KEY,
    OrderID NVARCHAR(50) NOT NULL,
    MenuID NVARCHAR(50) NOT NULL,
    Quantity INT,
    Status NVARCHAR(50) CHECK (Status IN ('Completed', 'In Progress', 'Failed')),
    CONSTRAINT FK_OrderItem_Order FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    CONSTRAINT FK_OrderItem_Menu FOREIGN KEY (MenuID) REFERENCES Menus(MenuID)
);
GO

CREATE TABLE EWallet (
    EWalletID NVARCHAR(50) PRIMARY KEY,
    CustomerID NVARCHAR(50) NOT NULL,
    Balance DECIMAL(10,2),
    CONSTRAINT FK_EWallet_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
GO

CREATE TABLE EWalletTopup (
    TopUpID NVARCHAR(50) PRIMARY KEY,
    EWalletID NVARCHAR(50) NOT NULL,
    CustomerID NVARCHAR(50) NOT NULL,
    Amount DECIMAL(10,2),
    [Date] DATE,
    Status NVARCHAR(50) CHECK (Status IN ('Completed', 'In Progress', 'Failed')),
    CONSTRAINT FK_EWalletTopup_EWallet FOREIGN KEY (EWalletID) REFERENCES EWallet(EWalletID),
    CONSTRAINT FK_EWalletTopup_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
GO

CREATE TABLE Feedback (
    FeedbackID NVARCHAR(50) PRIMARY KEY,
    ManagerID NVARCHAR(50) NULL,
    CustomerID NVARCHAR(50) NOT NULL,
    OrderID NVARCHAR(50) NOT NULL,
    [Date] DATE,
    Rating INT CHECK (Rating BETWEEN 1 AND 5),
    Customer_Feedback NVARCHAR(255),
    Response NVARCHAR(255),
    CONSTRAINT FK_Feedback_Manager FOREIGN KEY (ManagerID) REFERENCES Manager(ManagerID),
    CONSTRAINT FK_Feedback_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    CONSTRAINT FK_Feedback_Order FOREIGN KEY (OrderID) REFERENCES [Order](OrderID)
);
GO

CREATE TABLE RefundRequest (
    RefundID NVARCHAR(50) PRIMARY KEY,
    ManagerID NVARCHAR(50) NULL,
    CustomerID NVARCHAR(50) NOT NULL,
    OrderID NVARCHAR(50) NOT NULL,
    Amount DECIMAL(10,2),
    [Date] DATE,
    Status NVARCHAR(50) CHECK (Status IN ('Accepted', 'Pending', 'Rejected')),
    Reason NVARCHAR(255),
    CONSTRAINT FK_RefundRequest_Manager FOREIGN KEY (ManagerID) REFERENCES Manager(ManagerID),
    CONSTRAINT FK_RefundRequest_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    CONSTRAINT FK_RefundRequest_Order FOREIGN KEY (OrderID) REFERENCES [Order](OrderID)
);
GO

/* =========================
   SAMPLE DATA
   ========================= */

INSERT INTO Account (Name, Password, Gender, PhoneNumber) VALUES
('Andrian', 'Andrian@123', 'Male', 88889999),
('Bella', 'Bella@456!', 'Female', 88887777),
('Chris', 'Chris789#', 'Male', 88886666),
('Dana', 'Dana2024$', 'Female', 88885555),
('Eddy', 'Eddy_001!', 'Male', 88884444),
('Fiona', 'Fiona*2025', 'Female', 88883333),
('George', 'George#007', 'Male', 88882222);
GO

INSERT INTO Role (RoleID, Name) VALUES
('R001', 'Admin'),
('R002', 'Manager'),
('R003', 'Chef'),
('R004', 'Customer');
GO

INSERT INTO AccountRoles (AccID, RoleID, Salary, LastAccessed) VALUES
(1, 'R001', 1000.00, '2025-06-09'),
(1, 'R004', 1000.00, '2025-06-09'),
(2, 'R002', 1000.00, '2025-06-09'),
(3, 'R003', 1000.00, '2025-06-09'),
(4, 'R003', 1000.00, '2025-06-09'),
(5, 'R004', 1000.00, '2025-06-09'),
(6, 'R004', 1000.00, '2025-06-09'),
(7, 'R004', 1000.00, '2025-06-09');
GO

INSERT INTO Admin (AdminID, AccountID) VALUES
('admin000001', 1);
GO

INSERT INTO Manager (ManagerID, AccountID) VALUES
('manager000001', 2);
GO

INSERT INTO Chef (ChefID, AccountID) VALUES
('chef000001', 3),
('chef000002', 4);
GO

INSERT INTO Customer (CustomerID, AccountID) VALUES
('cust000001', 5),
('cust000002', 6),
('cust000003', 7);
GO

INSERT INTO Menus (MenuID, Name, Description, Price, Category, Availability, Duration, Image_url) VALUES
('menu000001', 'Nasi Lemak', 'Classic Malaysian rice dish with sambal and egg.', 5.50, 'Local', 'Available', 30, 'img1.jpg'),
('menu000002', 'Roti Canai', 'Flaky flatbread served with curry.', 3.00, 'Local', 'Available', 40, 'img2.jpg'),
('menu000003', 'Vegetable Stir Fry', 'Mixed vegetables sauteed with soy sauce.', 6.20, 'Vegetarian', 'Available', 25, 'img3.jpg'),
('menu000004', 'Margherita Pizza', 'Thin crust with tomato, mozzarella, and basil.', 11.90, 'Italian', 'Available', 15, 'img4.jpg'),
('menu000005', 'Spaghetti Bolognese', 'Spaghetti with minced beef and tomato sauce.', 12.50, 'Italian', 'Available', 20, 'img5.jpg'),
('menu000006', 'Taco Trio', 'Three assorted soft tacos with salsa.', 10.00, 'Mexican', 'Available', 18, 'img6.jpg'),
('menu000007', 'Quesadilla', 'Grilled tortilla with cheese and veggies.', 8.00, 'Mexican', 'Unavailable', 10, 'img7.jpg'),
('menu000008', 'Teh Tarik', 'Malaysian pulled milk tea.', 2.50, 'Drinks', 'Available', 50, 'img8.jpg'),
('menu000009', 'Iced Lemon Tea', 'Chilled black tea with lemon.', 3.00, 'Drinks', 'Available', 35, 'img9.jpg'),
('menu000010', 'Milo Ais', 'Iced chocolate malt drink.', 3.20, 'Drinks', 'Available', 40, 'img10.jpg'),
('menu000011', 'Cendol', 'Iced dessert with coconut milk and palm sugar.', 4.00, 'Local', 'Unavailable', 5, 'img11.jpg'),
('menu000012', 'Tofu Salad', 'Fresh greens with tofu cubes and sesame dressing.', 7.00, 'Vegetarian', 'Available', 22, 'img12.jpg'),
('menu000013', 'Vegetarian Lasagna', 'Baked lasagna with veggie layers.', 11.50, 'Vegetarian', 'Available', 12, 'img13.jpg'),
('menu000014', 'Tomato Bruschetta', 'Toasted bread topped with tomatoes and basil.', 6.50, 'Italian', 'Available', 14, 'img14.jpg'),
('menu000015', 'Guacamole & Chips', 'Avocado dip with tortilla chips.', 7.20, 'Mexican', 'Unavailable', 8, 'img15.jpg');
GO

INSERT INTO [Order] (OrderID, ChefID, CustomerID, TotalOrderFee, [Date], Status) VALUES
('ord202506011001', 'chef000002', 'cust000002', 36.40, '2025-06-04', 'Failed'),
('ord202506011002', 'chef000002', 'cust000001', 9.00, '2025-06-08', 'Completed'),
('ord202506011003', 'chef000002', 'cust000003', 10.00, '2025-06-01', 'Completed'),
('ord202506011004', 'chef000002', 'cust000001', 9.00, '2025-06-03', 'In Progress'),
('ord202506011005', 'chef000001', 'cust000002', 8.00, '2025-06-04', 'Completed'),
('ord202506011006', 'chef000001', 'cust000003', 24.00, '2025-06-06', 'Completed'),
('ord202506011007', 'chef000002', 'cust000001', 18.00, '2025-06-07', 'Completed'),
('ord202506011008', 'chef000001', 'cust000003', 9.50, '2025-06-02', 'Completed'),
('ord202506011009', 'chef000001', 'cust000002', 13.00, '2025-06-03', 'Completed'),
('ord202506011010', 'chef000001', 'cust000001', 25.00, '2025-06-05', 'Completed'),
('ord202506011011', 'chef000002', 'cust000002', 9.00, '2025-06-08', 'In Progress'),
('ord202506011012', 'chef000002', 'cust000001', 12.40, '2025-06-09', 'Completed'),
('ord202506011013', 'chef000002', 'cust000003', 8.00, '2025-06-02', 'Completed'),
('ord202506011014', 'chef000002', 'cust000002', 13.00, '2025-06-10', 'Completed'),
('ord202506011015', 'chef000001', 'cust000001', 9.00, '2025-06-06', 'Completed'),
('ord202506011016', 'chef000001', 'cust000003', 8.70, '2025-06-03', 'Completed'),
('ord202506011017', 'chef000002', 'cust000002', 4.00, '2025-06-07', 'Completed'),
('ord202506011018', 'chef000001', 'cust000003', 14.00, '2025-06-09', 'Completed'),
('ord202506011019', 'chef000001', 'cust000002', 7.00, '2025-06-04', 'Completed'),
('ord202506011020', 'chef000002', 'cust000001', 18.00, '2025-06-01', 'Completed');
GO

INSERT INTO OrderItem (OrderItemID, OrderID, MenuID, Quantity, Status) VALUES
('oitm202506011001', 'ord202506011001', 'menu000007', 3, 'Completed'),
('oitm202506011002', 'ord202506011001', 'menu000003', 2, 'Failed'),
('oitm202506011003', 'ord202506011002', 'menu000002', 3, 'Completed'),
('oitm202506011004', 'ord202506011003', 'menu000006', 1, 'Completed'),
('oitm202506011005', 'ord202506011004', 'menu000009', 3, 'In Progress'),
('oitm202506011006', 'ord202506011005', 'menu000007', 1, 'Completed'),
('oitm202506011007', 'ord202506011006', 'menu000005', 2, 'Completed'),
('oitm202506011008', 'ord202506011007', 'menu000006', 1, 'Completed'),
('oitm202506011009', 'ord202506011007', 'menu000008', 2, 'Completed'),
('oitm202506011010', 'ord202506011008', 'menu000001', 1, 'Completed'),
('oitm202506011011', 'ord202506011008', 'menu000009', 1, 'Completed'),
('oitm202506011012', 'ord202506011009', 'menu000003', 2, 'Completed'),
('oitm202506011013', 'ord202506011010', 'menu000005', 2, 'Completed'),
('oitm202506011014', 'ord202506011011', 'menu000010', 3, 'In Progress'),
('oitm202506011015', 'ord202506011012', 'menu000012', 1, 'Completed'),
('oitm202506011016', 'ord202506011012', 'menu000008', 2, 'Completed'),
('oitm202506011017', 'ord202506011013', 'menu000007', 1, 'Completed'),
('oitm202506011018', 'ord202506011014', 'menu000005', 1, 'Completed'),
('oitm202506011019', 'ord202506011014', 'menu000008', 1, 'Completed'),
('oitm202506011020', 'ord202506011015', 'menu000002', 3, 'Completed'),
('oitm202506011021', 'ord202506011016', 'menu000003', 1, 'Completed'),
('oitm202506011022', 'ord202506011016', 'menu000008', 1, 'Completed'),
('oitm202506011023', 'ord202506011017', 'menu000011', 1, 'Completed'),
('oitm202506011024', 'ord202506011018', 'menu000004', 1, 'Completed'),
('oitm202506011025', 'ord202506011019', 'menu000012', 1, 'Completed'),
('oitm202506011026', 'ord202506011020', 'menu000004', 1, 'Completed'),
('oitm202506011027', 'ord202506011020', 'menu000006', 1, 'Completed');
GO

INSERT INTO EWallet (EWalletID, CustomerID, Balance) VALUES
('ewallet000001', 'cust000001', 75.00),
('ewallet000002', 'cust000002', 55.00),
('ewallet000003', 'cust000003', 68.00);
GO

INSERT INTO EWalletTopup (TopUpID, EWalletID, CustomerID, Amount, [Date], Status) VALUES
('topup000001', 'ewallet000001', 'cust000001', 30.00, '2025-06-01', 'Completed'),
('topup000002', 'ewallet000001', 'cust000001', 45.00, '2025-06-06', 'Completed'),
('topup000003', 'ewallet000002', 'cust000002', 25.00, '2025-06-02', 'Completed'),
('topup000004', 'ewallet000002', 'cust000002', 30.00, '2025-06-08', 'Completed'),
('topup000005', 'ewallet000003', 'cust000003', 40.00, '2025-06-03', 'Completed'),
('topup000006', 'ewallet000003', 'cust000003', 28.00, '2025-06-09', 'Completed'),
('topup000007', 'ewallet000001', 'cust000001', 25.00, '2025-06-10', 'Completed'),
('topup000008', 'ewallet000003', 'cust000003', 20.00, '2025-06-05', 'Completed');
GO

INSERT INTO RefundRequest (RefundID, ManagerID, CustomerID, OrderID, Amount, [Date], Status, Reason) VALUES
('rfd20250601001', NULL, 'cust000002', 'ord202506011001', 36.40, '2025-06-05', 'Pending', 'System failure during checkout'),
('rfd20250601002', NULL, 'cust000001', 'ord202506011004', 9.00, '2025-06-04', 'Pending', 'Item never arrived'),
('rfd20250601003', 'manager000001', 'cust000002', 'ord202506011011', 9.00, '2025-06-09', 'Accepted', 'Order delayed beyond promised time'),
('rfd20250601004', 'manager000001', 'cust000003', 'ord202506011008', 9.50, '2025-06-03', 'Rejected', 'Customer changed mind after order'),
('rfd20250601005', NULL, 'cust000003', 'ord202506011018', 14.00, '2025-06-10', 'Pending', 'Spoiled item received'),
('rfd20250601006', 'manager000001', 'cust000001', 'ord202506011020', 18.00, '2025-06-02', 'Accepted', 'Wrong menu item delivered');
GO

INSERT INTO Feedback (FeedbackID, ManagerID, CustomerID, OrderID, [Date], Rating, Customer_Feedback, Response) VALUES
('fdb20250601001', NULL, 'cust000001', 'ord202506011002', '2025-06-09', 5, 'Food arrived hot and tasty!', ''),
('fdb20250601002', 'manager000001', 'cust000003', 'ord202506011003', '2025-06-02', 4, 'Good taste but portion was small.', 'We will work on portion sizes.'),
('fdb20250601003', 'manager000001', 'cust000002', 'ord202506011005', '2025-06-05', 5, 'Perfect packaging and flavor.', 'Thank you for your kind words!'),
('fdb20250601004', NULL, 'cust000003', 'ord202506011006', '2025-06-07', 3, 'Delivery was late, but food was okay.', ''),
('fdb20250601005', 'manager000001', 'cust000001', 'ord202506011007', '2025-06-08', 4, 'Everything was great but too spicy.', 'Thanks! We will note your preference.'),
('fdb20250601006', 'manager000001', 'cust000003', 'ord202506011008', '2025-06-03', 5, 'Very fresh and delicious!', 'Happy to hear that!'),
('fdb20250601007', NULL, 'cust000002', 'ord202506011009', '2025-06-04', 2, 'Food was cold on arrival.', ''),
('fdb20250601008', 'manager000001', 'cust000001', 'ord202506011010', '2025-06-06', 5, 'Great variety and taste.', 'Thanks for the feedback!');
GO

/* =========================
   OPTIONAL QUICK CHECKS
   ========================= */
-- SELECT * FROM Account;
-- SELECT * FROM Role;
-- SELECT * FROM AccountRoles;
-- SELECT * FROM Menus;
-- SELECT * FROM [Order];
-- SELECT * FROM OrderItem;
-- SELECT * FROM EWallet;
-- SELECT * FROM EWalletTopup;
-- SELECT * FROM RefundRequest;
-- SELECT * FROM Feedback;
