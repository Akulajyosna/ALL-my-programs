create database handson2
drop table salesman
create table salesman(salesman_id  int primary key,name varchar(100),city varchar(100),commission decimal(5,2))
insert into salesman values(5001,'James Hoog','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
insert into salesman values(5007,'Paul Adam','Rome',0.13)
insert into salesman values(5003,'Lauson Hen','San Jose',0.12)
select count(city) as counting  from salesman 
select * from salesman

drop table orders
create table orders(ord_no int primary key,purch_amt decimal(8,2),ord_date Date,customer_id int,salesman_id int )
insert into orders values(70001,150.5,'2012-10-05',3005,5002)
insert into orders values(70009,270.65,'2012-09-10',3001,5005)
insert into orders values(70002,65.26,'2012-10-05',3002,5001)
insert into orders values(70004,110.5,'2012-08-17',3009,5003)
insert into orders values(70007,948.5,'2012-09-10',3005,5002)
insert into orders values(70005,2400.6,'2012-07-27',3007,5001)
insert into orders values(70008,5760,'2012-09-10',3002,5001)
insert into orders values(70010,1983.43,'2012-10-10',3004,5006)
insert into orders values(70003,2480.4,'2012-10-10',3009,5003)
insert into orders values(70012,250.45,'2012-06-27',3008,5002)
insert into orders values(70011,75.29,'2012-08-17',3003,5007)
insert into orders values(70013,3045.6,'2012-04-25',3002,5001)
select ord_date,salesman_id,COUNT(*) from orders group by ord_date,salesman_id
select count(*) as counting from orders where ord_date='2012-08-17'
select salesman_id ,MAX(purch_amt) from orders group by salesman_id having salesman_id between 5003 and 5008
select * from orders

drop table customers
create table customers(customer_id int primary key,cust_name varchar(100),city varchar(100),grade int,salesman_id int )
insert into customers values(3002,'Nick Rimando','New York',100,5001)
insert into customers values(3007,'Brad Davis','New York',200,5001)
insert into customers values(3005,'Graham Zusi','California',200,5002)
insert into customers values(3008,'Julian Green','London',300,5002)
insert into customers values(3004,'Fabian Johnson','Paris',300,5006)
insert into customers values(3009,'Geoff Cameron','Berlin',100,5003)
insert into customers values(3003,'Jozy Altidor','Moscow',200,5007)
--insert into customers values(3001,'Brad Guzan','London',5005)
select * from customers