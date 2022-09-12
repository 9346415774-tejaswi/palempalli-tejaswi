/*1st
create database Day3_assingnment;

use Day3_assingnment;

create table Customers (
   Customerid char primary key,
   CompanyName varchar(40),
   contactName char(30),
   Address varchar(max) ,
   City char(15) ,
   Phone char(24) ,
   Fax char(24) ,
   
);
select * from Customers;

CREATE TABLE Orders(
OrderId integer primary key,
customerId char foreign key references Customers(customerId) ,
Orderdate datetime ,
Shippeddate datetime ,
Freight money ,
Shipname varchar(40) ,
Shipaddres varchar(max) ,
Quantity integer ,
);

select * from Customers;
select * from Orders;
*/
/*2 nd
select * from Orders
--set default constraint
alter table Orders alter column Quantity int NOT NULL;
*/
/* 3 rd
select * from Orders
--set default constraint
alter table Orders alter column Quantity int NOT NULL;
alter table Orders ADD CONSTRAINT UQ_Orders_OrderId unique(OrderId);
alter table Orders ADD CHECK(Quantity>5);
alter table Orders add constraint default_Shippeddate default getdate() for Shippeddate;
*/
/*4th
--alter table Customers
--drop constraint Customerid;
select * from Customers 
where Customerid='fk_gr_Customerid'

if exists(select * from Customers  where Customerid='fk_gr_Customerid')
begin
alter table Customers
drop constraint fk_gr_Customerid
end;
*/
/*5th
alter table Orders alter column Quantity int  NULL;
*/
/*6th
DECLARE @CurrentDate DATE = CAST(GETDATE() AS DATE), @DOB DATE = '1998-09-18', @Years INT = 0, @Months INT = 0, @Days INT = 0
SET @Years = DATEDIFF(DAY,@DOB,@CurrentDate)/365
SET @Months = DATEDIFF(MONTH,DATEADD(YEAR,DATEDIFF(DAY,@DOB,@CurrentDate)/365,@DOB),@CurrentDate)
SET @Days = DATEDIFF(DAY,DATEADD(Month,DATEDIFF(MONTH,DATEADD(YEAR,DATEDIFF(DAY,@DOB,@CurrentDate)/365,@DOB),@CurrentDate),DATEADD(YEAR,DATEDIFF(DAY,@DOB,@CurrentDate)/365,@DOB)),@CurrentDate)
SELECT CONCAT (@Years, ' Years, ', @Months, ' Months and ', @Days, ' Days') AS DateOfBirth
*/

