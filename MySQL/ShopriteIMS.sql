Drop Database ShopriteIMS;

CREATE DATABASE ShopriteIMS;
USE ShopriteIMS;

CREATE TABLE ProductCategories (
    Category_Name VARCHAR(30) PRIMARY KEY
);

INSERT INTO ProductCategories VALUES
	('Beverages'),  ('Bread/Bakery'),  ('Cannned Goods'),  ('Diary'),  ('Dry/Baking Goods'), 
	('Frozen'),  ('Meat'),  ('Produce'),  ('Cleaners'),  ('Paper Goods'),  ('Personal Care');
    
CREATE TABLE EmployeeInfo (
	Employee_ID INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(30) NOT NULL UNIQUE,
    First_Name VARCHAR(30) NOT NULL, 
    Last_Name VARCHAR(30) NOT NULL,
    Email VARCHAR(30) NOT NULL,
    Telephone INT NOT NULL,
    Password VARCHAR(30) CHARACTER SET BINARY NOT NULL,
    Status VARCHAR(30) NOT NULL
);

INSERT INTO EmployeeInfo VALUES 
	(1, 'Prince1nOnly', 'Prince', 'Tawiah', 'ptawiah@gmail.com', 0553289833, 'nightAngelX', 'Administrator'), 
    (2, 'AstroNelson', 'Nelson', 'Addo', 'nelsonafari@gmail.com', 0543281372, 'spaceExplorer99', 'Attendant'), 
    (3, 'Musical', 'Kweku', 'Kinata', 'kwakuKB@gmail.com', 0209993377, 'lalalalalaC#', 'Attendant'), 
    (4, 'Parody', 'Kingsley', 'Freeman', 'kingsleykudjo@gmail.com', 0245557733, 'excellenceA-Z', 'Attendant'),
    (5, 'EdwinX', 'Edwin', 'Teteh', 'edwinay@gmail.com', 0553289843, '@extrOdinary', 'Attendant');
    
CREATE TABLE PastEmployees (
	Employee_ID INT PRIMARY KEY,
    First_Name VARCHAR(30) NOT NULL, 
    Last_Name VARCHAR(30) NOT NULL,
    Email VARCHAR(30) NOT NULL,
    Telephone INT NOT NULL,
    Status VARCHAR(30) NOT NULL,
    Removal_Reason VARCHAR(20) NOT NULL,
    Reason_Description VARCHAR(250)
);    

CREATE TABLE Products (
	Product_ID INT PRIMARY KEY AUTO_INCREMENT, 
    Product VARCHAR(30) NOT NULL,
    Category VARCHAR(30) NOT NULL, 
    Barcode VARCHAR(14) NOT NULL, 
    Quantity INT NOT NULL, 
    Size VARCHAR(10), 
    Volume VARCHAR(10), 
    Weight VARCHAR(10), 
    Unit_Cost_Price DECIMAL(6,  2) NOT NULL, 
    Unit_Selling_Price DECIMAL(6,  2) NOT NULL, 
    Gross_Price DECIMAL(6,  2) NOT NULL, 
    Reorder_Level INT NOT NULL,  
    FOREIGN KEY(Category) REFERENCES ProductCategories(Category_Name)
);

INSERT INTO Products VALUES 
	(216, 'coffee',  'Beverages',  '0000000001',  50, 'L', '50', '200', 10.00, 12.00, 13.00, 2), 
    (217, 'juice',  'Beverages', '0000000002',  20, 'L', '100', '400', 20.00, 21.00, 22.00, 5), 
    (218, 'soda',  'Beverages', '0000000003',  25, 'L', '50', '250', 5.00, 6.00, 7.00, 5), 
    (219, 'sandwich loaves',  'Bread/Bakery',  '0000000004',  30, 'M', NULL, '500', 5.00, 6.00, 7.00, 5), 
    (220, 'dinnerrolls',  'Bread/Bakery',  '0000000005',  21, 'L', NULL, '300', 6.00, 7.00, 8.00, 2), 
    (221, 'bagels', 'Bread/Bakery', '0000000006', 30, 'S', NULL, '200', 6.00, 7.00, 8.00, 5), 
    (222, 'vegetables', 'Cannned Goods', '0000000007',  40, 'L', NULL, '400', 5.00, 6.00, 7.00, 5), 
    (223, 'spaghetti sauce ', 'Cannned Goods', '0000000008',  100, 'M', NULL, '250', 10.00, 11.00, 12.00, 10), 
    (224, 'ketchup', 'Cannned Goods', '0000000009',  100, 'S', '100', '300', 15.00, 16.00, 17.00, 10), 
    (225, 'cheese ', 'Diary', '0000000010',  200, 'L', '50', '200', 5.00, 7.00, 8.00, 20), 
    (226, 'eggs ', 'Diary', '0000000011',  60, 'M', NULL, '1000', 3.00, 5.00, 6.00, 10), 
    (227, 'milk', 'Diary', '0000000012',  90, 'S', '500', '200', 5.00, 7.00, 8.00, 5), 
    (228, 'yoghurt', 'Diary', '0000000013',  80, 'L', '100', '200', 2.00, 4.00, 5.00, 5), 
    (229, 'butter', 'Diary', '0000000014',  80, 'L', NULL, '100', 3.00, 5.00, 6.00, 5), 
    (230, 'cereals', 'Dry/Baking Goods', '0000000015',  55, 'M', '50', '50', 3.00, 3.00, 4.00, 5), 
    (231, 'flour', 'Dry/Baking Goods', '0000000016',  59, 'M', '35', '50', 6.00, 7.00, 8.00, 5), 
    (232, 'sugar', 'Dry/Baking Goods', '0000000017',  90, 'M', '200', '250', 1.00, 3.00, 4.00, 5), 
    (233, 'pasta', 'Dry/Baking Goods', '0000000018',  200, 'L', '500', '350', 1.00, 3.00, 4.00, 5), 
    (234, 'mixes', 'Dry/Baking Goods', '0000000019',  30, 'L', NULL, '200', 9.00, 10.00, 11.00, 5), 
    (235, 'waffles', 'Frozen', '0000000020',  20, 'S', NULL, '500', 10.00, 11.00, 12.00, 2), 
    (236, 'ice creams', 'Frozen', '0000000021',  50, 'S', '20', '200', 5.00, 6.00, 7.00, 5), 
    (237, 'vegatables', 'Frozen', '0000000022',  50, 'S', NULL, '250', 5.00, 6.00, 7.00, 5), 
    (238, 'lunch meat ', 'Meat', '0000000023',  100, 'S', NULL, '300', 20.00, 22.00, 23.00, 5), 
    (239, 'poultry ', 'Meat', '0000000024',  20, 'L', NULL, '200', 30.00, 32.00, 33.00, 5), 
    (240, 'beef', 'Meat', '0000000025',  30, 'L', NULL, '100', 40.00, 42.00, 43.00, 5), 
    (241, 'pork', 'Meat', '0000000026',  50, 'L', NULL, '500', 35.00, 36.00, 37.00, 5), 
    (242, 'fruits', 'Produce', '0000000027',  45, 'M', NULL, '20', 5.00, 6.00, 8.00, 5), 
    (243, 'laundry detergent', 'Cleaners', '0000000028',  40, 'M', '300', '300', 5.00, 6.00, 7.00, 5), 
    (244, 'dish washing liquid', 'Cleaners', '0000000029',  50, 'L', '100', '400', 9.00, 10.00, 11.00, 5), 
    (245, 'paper towels', 'Paper Goods', '0000000030',  60, 'L', NULL, '200', 5.00, 10.00, 11.00, 5), 
    (246, 'toilet paper', 'Paper Goods', '0000000031',  55, 'S', NULL, '5', 6.00, 7.00, 8.00, 5), 
    (247, 'aluminium foil', 'Paper Goods', '0000000032',  35, 'S', NULL, '15', 7.00, 8.00, 9.00, 5), 
    (248, 'sandwich bags', 'Paper Goods', '0000000033',  25, 'L', NULL, '30', 3.00, 5.00, 6.00, 5), 
    (249, 'shampoo', 'Personal Care', '0000000034',  20, 'L', '250', '400', 35.00, 37.00, 39.00, 5), 
    (250, 'soap', 'Personal Care', '0000000035',  100, 'M', NULL, '200', 6.00, 7.00, 8.00, 5), 
    (251, 'hand soap', 'Personal Care', '0000000036',  80, 'M', NULL, '100', 5.00, 6.00, 7.00, 10), 
    (252, 'shaving cream', 'Personal Care', '0000000037',  70, 'S', '100', '100', 15.00, 16.00, 17.00, 2), 
    (253, 'tortillas', 'Bread/Bakery', '0000000038',  50, 'S', NULL, '150', 4.00, 6.00, 7.00, 2);
    
    DESCRIBE Products;
    DESCRIBE EmployeeInfo;
    
    SELECT * FROM Products;
    SELECT * FROM EmployeeInfo;
    
    Select barcode, quantity, reorder_level, size, weight, volume, unit_cost_price, unit_selling_price, gross_price from products
	where product = 'coffee' and category = 'beverages';