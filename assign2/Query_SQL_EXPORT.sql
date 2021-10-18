-- Membuat database BANK --
create database BANK;

-- Mengganti database yang digunakan menjadi BANK --
use BANK;

-- Membuat table customer --
create table customers (
	customerNumber int identity (1,1) primary key,
	customerName varchar(50) null,
	contactLastName varchar(50) null,
	contactFirstName varchar(50) null,
	phone varchar(15) null,
	addressLine1 varchar(100) null,
	addressLine2 varchar(100) null,
	city varchar(20) null,
	state varchar(20) null,
	postalCode varchar(5) null,
	salesRepEmployeeNumber int,
	creditLimit float
)

-- Alter tipe data kolom creditLimit menjadi money (karena lebih cocok untuk keuangan)--
alter table customers alter column creditLimit money;

-- Membuat table products --
create table products (
	productCode int identity (1,1) primary key,
	productName varchar(50),
	productLine int,
	productScale tinyint,
	productVendor varchar(50),
	productDescription text,
	quantityInStock int,
	buyPrice money,
	MSRP money
)

-- Membuat table productlines --
create table productlines (
	productLine int identity (1,1) primary key,
	textDescription text not null,
	htmlDescription text,
	imageProduct varchar(255)
)

-- Mengubah kolom productLine pada table products menjadi foreign key terhadap table productlines --
alter table products add foreign key (productLine) references productlines(productLine);

-- Membuat table orders --
create table orders (
	orderNumber int identity (1,1) primary key,
	orderDate date not null,
	requiredDate date not null,
	shippedDate date not null,
	status bit not null,
	comments text,
	customerNumber int,
	constraint FK_CustomerOrder foreign key (customerNumber) references customers(customerNumber)
)

-- Membuat table orderdetails --
create table orderdetails (
	orderNumber int identity (1,1) primary key,
	productCode int not null,
	quantityOrdered int not null,
	priceEach money not null,
	orderLineNumber int not null,
	constraint FK_ProductOrderDetail foreign key (productCode) references products(productCode),
	constraint FK_OrderOrderDetail foreign key (orderLineNumber) references orders(orderNumber)
)

-- Membuat table payments --
create table payments (
	customerNumber int not null,
	checkNumber int identity (1,1) primary key,
	paymentDate date not null,
	amount money not null
	constraint FK_CustomerPayment foreign key (customerNumber) references customers(customerNumber)
)

-- Membuat table employee --
create table employee (
	employeeNumber int identity (1,1) primary key,
	firstName varchar(25) not null,
	lastName varchar(25) not null,
	extension varchar(25),
	email varchar(25) not null,
	officeCode int,
	reportsTo int,
	jobTitle varchar(25),
	constraint FK_EmployeeEmployee foreign key (reportsTo) references employee(employeeNumber)
)

-- Membuat table offices --
create table offices (
	officeCode int identity (1,1) primary key,
	city varchar(25) not null,
	phone varchar(15) not null,
	addressLine1 varchar(100),
	addressLine2 varchar(100),
	state varchar(20) not null,
	country varchar(20) not null,
	postalCode varchar(5) not null,
	territory varchar(20)
)

-- Mengubah kolom officeCode pada table employee menjadi foreign key terhadap table offices --
alter table employee add constraint FK_OfficesEmployee foreign key (officeCode) references offices(officeCode);

-- Mengubah kolom salesRepEmployeeNumber pada table customers menjadi foreign key terhadap table employee --
alter table customers add constraint FK_EmployeeCustomers foreign key (salesRepEmployeeNumber) references employee(employeeNumber);

-- Insert nilai table customers --
insert into customers (customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, salesRepEmployeeNumber, creditLimit)
values
('Lana Lovell', 'Lovell', 'Lana', '0812100', 'Street 1', 'District 1', 'Jakarta', 'DKI Jakarta', '20115', null, 20000000),
('Malakai Newman', 'Newman', 'Malakai', '0812101', 'Street 2', 'District 1', 'Jakarta', 'DKI Jakarta', '20116', null, 40000000),
('Kaylan Parra', 'Parra', 'Kaylan', '0812102', 'Street 1', 'District 2', 'Bogor', 'Jawa Barat', '30115', null, 20000000),
('Arvin Richard', 'Richard', 'Arvin', '0812103', 'Street 3', 'District 2', 'Semarang', 'Jawa Tengah', '40115', null, 15000000),
('Arda Barclay', 'Barclay', 'Arda', '0812104', 'Street 2', 'District 1', 'Bogor', 'Jawa Barat', '30116', null, 5000000);

-- Insert nilai table --
insert into products (productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP)
values
('RTX 3060 Ti', null, '6', 'Nvidia', 'Mid-range GPU from Nvidia', 4, 1000, 400),
('RX 6700 XT', null, '7', 'AMD', 'Mid-range GPU from AMD', 6, 1200, 500),
('RTX 3090', null, '9', 'Nvidia', 'High-end GPU from Nvidia', 2, 2500, 1500),
('R7 5800X', null, '8', 'AMD', 'High-end CPU from AMD', 2, 750, 600),
('i5 11400F', null, '4', 'Intel', 'Mid-range CPU from Intel', 10, 200, 150);

-- Insert nilai productlines --
insert into productlines (textDescription, imageProduct)
values
('CPU - Central Processing Unit', 'img/cpu.img'),
('GPU - Graphics Processing Unit', 'img/gpu.img');

-- Menambahkan productline pada products --
update products set productLine = 1 where productDescription like '%CPU%';
update products set productLine = 2 where productDescription like '%GPU%';

-- Insert nilai orders --
insert into orders (orderDate, requiredDate, shippedDate, status, comments, customerNumber)
values
('2021-08-29', '2021-09-01', '2021-08-30', 3, 'delivered', 2),
('2021-09-01', '2021-09-05', '2021-09-04', 2, 'ongoing', 2),
('2021-09-01', '2021-10-01', '2021-09-15', 1, 'processed', 3),
('2021-08-29', '2021-09-01', '2021-08-30', 3, 'delivered', 4),
('2021-09-01', '2021-09-05', '2021-09-04', 2, 'ongoing', 4);

-- Insert nilai orderdetails --
insert into orderdetails (productCode, quantityOrdered, priceEach, orderLineNumber)
values
(1, 1, 1000, 2),
(4, 1, 750, 3),
(2, 1, 1200, 4),
(3, 1, 2500, 5),
(5, 1, 200, 6);

-- Insert nilai payments --
insert into payments (customerNumber, paymentDate, amount)
values
(2, '2021-08-29', 1000),
(2, '2021-09-01', 750),
(3, '2021-09-01', 1200),
(4, '2021-08-29', 2500),
(4, '2021-09-01', 200);

-- Insert nilai offices --
insert into offices (city, phone, addressLine1, state, country, postalCode)
values
('Jakarta', '06112', 'Street 1', 'DKI Jakarta','Indonesia','20115'),
('Bogor', '06113', 'Street 2', 'Jawa Barat','Indonesia','30115'),
('Semarang', '06114', 'Street 3', 'Jawa Tengah','Indonesia','40115'),
('Surabaya', '06115', 'Street 4', 'Jawa Timur','Indonesia','50115'),
('Malang', '06116', 'Street 5', 'Jawa Timur','Indonesia','30115');

-- Insert nilai employee --
insert into employee (firstName, lastName, email, officeCode, reportsTo, jobTitle)
values
('Lulu', 'Mcgee', 'employee1@email.com', 1, null, 'Manager'),
('Ahyan', 'Sullivan', 'employee2@email.com', 1, 1, 'Assistant Manager'),
('Dilan', 'Ball', 'employee3@email.com', 1, 2, 'Team Leader'),
('Roger', 'Riley', 'employee4@email.com', 1, 3, 'Staff'),
('Lemar', 'Barr', 'employee5@email.com', 1, 3, 'Staff');

-- Menambahkan salesRepEmployeeNumber pada customer --
update customers set salesRepEmployeeNumber = 4 where city like 'Jakarta';
update customers set salesRepEmployeeNumber = 5 where city like 'Bogor';

-- Custom Query 1 : Tampilkan customer yang berada pada kota office bersangkutan --
select offices.city as officeCity, customers.customerName 
from offices full join customers
on offices.city = customers.city;

-- Custom Query 2 : Tampilkan product dengan deskripsi productline yang bersangkutan --
select products.productName, products.productDescription, productlines.textDescription as productCategory
from products left join productlines
on products.productLine = productlines.productLine;

-- Custom Query 3 : Tampilkan jumlah employee per kantor dari yang terbanyak --
select offices.city as kotaOffice, count(employee.employeeNumber) as jumlahPegawai
from employee right join offices
on employee.officeCode = offices.officeCode
group by offices.city
order by count(employee.employeeNumber) desc;

-- Custom Query 4 : Tampilkan semua customer dengan jumlah order lebih dari satu --
select customers.customerName, customers.phone, count(orders.orderNumber) as jumlahOrder
from customers left join orders
on orders.customerNumber = customers.customerNumber
group by customers.customerName, customers.phone
having count(orders.orderNumber) > 1;

-- Custom Query 5 : Tampilkan semua customer dan pegawai beserta kota dan statusnya --
select customers.customerName as nama, customers.city as city, 'Customer' as status from customers
group by customers.city, customers.customerName
union
select employee.firstName, sub.* , 'Pegawai' as status from employee, (select offices.city from employee, offices where offices.officeCode = employee.officeCode) sub;

select * from customers;