create database finalproject
use finalproject

create table tblProduct(
productId int not null primary key,
productName varchar(100) not null,
productQty int not null,
batchNo varchar(100) not null,
unitPrice decimal not null,
manufactureDate date not null,
expireDate date not null);

SELECT * FROM tblProduct
insert into tblProduct values (1, 'Banana', 1, 'edd', 120, '10/11/2023', '10/11/1111');
SELECT ISNULL(MAX(productId), 0) + 1 FROM tblProduct

create table tblEmployee(
empId int not null primary key,
empName varchar(100) not null,
empType varchar(100) not null,
empUsername varchar(100) not null,
empPassword varchar(100) not null,
empNIC varchar(50) not null,
empContact varchar(11) not null,
empEmail varchar(100) not null,
empAddress varchar(100) not null,
joinedDate date not null);

ALTER TABLE tblEmployee ADD empStatus varchar(30) not null default('Available');
select * from tblEmployee
select empId, empName, empType, empUsername, empPassword, empNIC, empContact, empEmail, empAddress, joinedDate from tblEmployee
select empId, empName from tblEmployee

create table tblSalary(
salaryId int not null primary key,
empId int not null foreign key references tblEmployee(empId),
empName varchar(100) not null,
bonus decimal,
otHrs int not null,
minimumSalary decimal not null,
totalSalary decimal not null,
Date date not null);

select * from tblSalary
SELECT ISNULL(MAX(salaryId), 0) + 1 FROM tblSalary

create table tblDamagedProduct(
damagedProductId int not null primary key,
productId int not null foreign key references tblProduct(productId),
productName varchar(100) not null,
Qty int not null,
DateAdded date not null);

select * from tblDamagedProduct
SELECT ISNULL(MAX(damagedProductId), 0) + 1 FROM tblDamagedProduct

create table tblSupplier(
supplierId int not null primary key,
supplierName varchar(100) not null,
supplierContact varchar(11) not null,
supplierEmail varchar(100) not null,
supplierAddress varchar(150) not null);

select * from tblSupplier
SELECT ISNULL(MAX(supplierId), 0) + 1 FROM tblSupplier

create table tblRestockProduct(
restockProductId int not null primary key,
productId int not null foreign key references tblProduct(productId),
productName varchar(100) not null,
requiredQty int not null,
DateAdded date not null);

select * from tblRestockProduct

create table tblRestockRequest(
restockRequestId int not null primary key,
restockProductId int foreign key references tblRestockProduct(restockProductId),
status varchar(25) default('Pending'),
date date not null);

select * from tblRestockRequest
delete from tblRestockRequest
insert into tblRestockRequest (restockRequestId) values (1);
SELECT ISNULL(MAX(restockRequestId), 0) + 1 FROM tblRestockRequest


insert into tblRestockProduct values (2, 1, '11d', 123, '2/20/2025')
select * from tblRestockProduct

create table tblDamagedProductRequest(
damageProductRequestId int not null primary key,
damagedProductId int foreign key references tblDamagedProduct(damagedProductId),
status varchar(25) default('Pending'),
date date not null);

select * from tblDamagedProductRequest

create table tblLeaveRequest(
leaveRequestId int not null primary key,
employeeId int not null foreign key references tblEmployee(empId),
leaveType varchar(30) not null,
description varchar(200) not null,
startDate date not null,
endDate date not null,
status varchar(25) default('Pending'));

select * from tblLeaveRequest
select leaveRequestId, status from tblLeaveRequest
select * from tblLeaveRequest where employeeId=1 and leaveRequestId=1

create table tblVehicle(
vehicleNo char(15) not null primary key,
vehcleType varchar(30) not null,
purchasedDate date not null,
vehicleStatus varchar(25) default('Idle'));

select * from tblVehicle

create table tblVehicleMaintenance(
maintenanceId int not null primary key,
vehicleNo char(15) not null foreign key references tblVehicle(vehicleNo),
jobDescription varchar(max) not null,
scheduledDate date not null);

create table tblDelivery(
deliveryId int not null primary key,
deliveryStatus varchar(25) default('Pending'),
orderId int not null,
retailerName varchar(100) not null,
retailerAddress varchar(100) not null,
driverId int not null foreign key references tblEmployee(empId),
driverName varchar(100) not null,
vehicleNo char(15) not null foreign key references tblVehicle(vehicleNo),
deliveryDate date not null);

select * from tblDelivery

create table tblRetailer(
retailerId int not null primary key,
retailerName varchar(100) not null,
retailerContact varchar(11) not null,
retailerEmail varchar(100) not null,
retailerAddress varchar(100) not null,
retailerPriority varchar(25) default('Normal'));

create table tblRetailerOrder(
orderId int not null primary key,
retailerId int not null foreign key references tblRetailer(retailerId),
productId int not null foreign key references tblProduct(productId),
productName varchar(100) not null,
productQty int not null,
unitPrice decimal not null,
orderDate date not null);

select * from tblRetailerOrder
SELECT MAX(orderId) FROM tblRetailerOrder
delete from tblRetailerOrder
select sum(unitPrice * productQty) from tblRetailerOrder where retailerId = 1


 SELECT tblRetailer.retailerName, tblRetailer.retailerId, tblRetailer.retailerContact, tblRetailer.retailerEmail, tblRetailer.retailerAddress, tblRetailerOrder.orderId, tblRetailerOrder.productId, tblRetailerOrder.productName, tblRetailerOrder.productQty, tblRetailerOrder.unitPrice, tblRetailerOrder.orderDate
 FROM tblRetailerOrder INNER JOIN tblRetailer ON tblRetailerOrder.retailerId = tblRetailer.retailerId where tblRetailerOrder.retailerId = 2

 select retailerName from tblRetailer inner join tblRetailerOrder on tblRetailerOrder.retailerId = tblRetailer.retailerId  where tblRetailerOrder.orderId = 1

 select productQty from tblProduct

 SELECT ProductName FROM tblProduct WHERE productQty = 0
 
 CREATE TABLE tblAnnouncement (
    announcementId INT PRIMARY KEY IDENTITY(1,1),
    title VARCHAR(255),
    message TEXT,
    postedOn DATE DEFAULT GETDATE()
);

select * from tblAnnouncement