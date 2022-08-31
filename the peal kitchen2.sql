create database ThePealKitchen;
use ThePealKitchen;

create table Customers
(
ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY CLUSTERED,
Customer_ID AS 'C' + RIGHT('000' + CAST(ID AS VARCHAR(5)), 5) PERSISTED ,
Name varchar (20),
Email varchar (30),
TP int,
Address varchar (30),
cus_password varchar(15)
);
select * from Waiter;
create table Manager (Manager_ID varchar (10)primary key not null constraint ck_Manager_ID check (Manager_ID LIKE 'M%'),
Name varchar (20),
Password varchar (10),
UserName varchar(10),status bit);

create table Waiter (Employee_ID varchar (10)primary key not null constraint ck_Employee_ID check (Employee_ID LIKE 'E%'),
Name varchar (20),
Age int,
TP int,
Gender varchar(8),
Address varchar(20),
M_ID varchar (10) foreign key references Manager (Manager_ID));

create table Orders
(

Order_ID INT IDENTITY(1000,1) NOT NULL PRIMARY KEY CLUSTERED,
O_ID AS 'O' + RIGHT('000' + CAST(Order_ID AS VARCHAR(5)), 5) PERSISTED ,
Order_date date default getdate(),
No_of_items int,
CID INT foreign key references Customers (ID),
EMP_ID varchar (10) foreign key references Waiter (Employee_ID)

);

create table Item (Item_ID varchar (10) primary key not null constraint ck_Item_ID check (Item_ID LIKE 'I%'),
Item_Name varchar (50),
Price decimal(8,2),
Quantity int);

create table Food (Item_ID varchar (10)primary key not null constraint ck_Food_ID check (Item_ID LIKE 'I%'),
Item_Name varchar (50),
Price decimal(8,2),
Quantity int);

create table Drink (Item_ID varchar (10) primary key not null constraint ck_Drink_ID check (Item_ID LIKE 'I%'),
Item_Name varchar (50),
Price decimal(8,2),
Quantity int);

create table Dessert (Item_ID varchar(10) primary key not null constraint ck_Dessert_ID check (Item_ID LIKE 'I%'),
Item_Name varchar (50),
Price decimal(8,2),
Quantity int);

create table Invoice (

invoice_ID INT IDENTITY(100,1) NOT NULL PRIMARY KEY CLUSTERED,
Inv_ID AS 'IN' + RIGHT('000' + CAST(invoice_ID AS VARCHAR(5)), 5) PERSISTED ,
Inv_Date date,
Ord_ID INT  foreign key references Orders (Order_ID),
cstmr_ID INT foreign key references Customers (ID)

);

create table Order_Item (O_ID INT foreign key references Orders (Order_ID),
I_ID varchar (10) foreign key references Item (Item_ID),Quantity int);

insert into Customers values
('testcustomer','test@gmail.com',0724234522,'colombo','test123',1),
('milinda','milinda@gmail.com',0724567652,'colombo','password',1);


insert into Manager values
('M001','Kasun','User123','userm001',1); 

insert into Waiter values 
('E001','Kasun',22,0772134542,'male','Kotte','M001'),
('E002','Amal',21,0785674390,'male','Kottawa','M001'),
('E003','Saranga',35,0713454542,'male','Colombo 2','M001'),
('E004','Chamara',30,0706753456,'male','Colombo 7','M001'),
('E005','Milinda',28,0763452675,'male','Homagama','M001'),
('E006','Janith',26,0723452150,'male','Colombo 8','M001');

insert into Orders values 
('2020-05-11',5,1,'E001');

insert into Item 
values
('I001','Chicken Fried Rice',350.00,150),
('I002','Chicken Biryani',450.00,90),
('I003','Nasi Rice',480.00,100),
('I004','Seafood Rice',550.00,80),
('I005','Spaghetti Bolognaise – Chicken Pasta',500.00,60),
('I006','Macaroni & Cheese Pasta',580.00,65),
('I007','Chicken Lasagna',650.00,40),
('I008','Chicken Spicy Noodles',400.00,50),
('I009','Seafood Noodles',600.00,45),
('I010','Vegetables noodles',300.00,70),
('I011','Chicken Kottu',380.00,155),
('I012','Egg Kottu',350.00,100),
('I013','Beef Kottu',550.00,30),
('I014','Seafood Kottu',450.00,55),

('I015','Pepsi 150ml',200.00,250),
('I016','Coca-Cola 150ml',200.00,200),
('I017','Cappuccino ',500.00,110),
('I018','Late',900.00,52),
('I019','Mint Mojito',400.00,75),

('I020','Lava cake',300.00,100),
('I021','Wattala pan',350.00,140),
('I022','Biscuit Pudding',300.00,130);

insert into Food 
values
('I001','Chicken Fried Rice',350,150),
('I002','Chicken Biryani',450,90),
('I003','Nasi Rice',480,100),
('I004','Seafood Rice',550,80),
('I005','Spaghetti Bolognaise – Chicken Pasta',500,60),
('I006','Macaroni & Cheese Pasta',550,60),
('I007','Chicken Lasagna',650,40),
('I008','Chicken Spicy Noodles',400,50),
('I009','Seafood Noodles',600,40),
('I010','Vegetables noodles',300,70),
('I011','Chicken Kottu',380,150),
('I012','Egg Kottu',350,100),
('I013','Beef Kottu',550,30),
('I014','Seafood Kottu',450,40);


insert into Drink 
values
('I015','Pepsi 150ml',200.00,250),
('I016','Coca-Cola 150ml',200.00,200),
('I017','Cappuccino ',500.00,110),
('I018','Late',900.00,52),
('I019','Mint Mojito',400.00,75);

insert into Dessert 
values
('I020','Lava cake',300.00,100),
('I021','Wattala pan',350.00,140),
('I022','Biscuit Pudding',300.00,130);

insert into Invoice values 
('2020-05-18',1000,1);

insert into Order_Item values
(1000,'I001',3),
(1000,'I003',4);



select * from Customers;






 











select * from Customers;
select * from Orders;

drop database ThePealKitchen