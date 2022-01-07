create database firstproject
create table mytable(
id int,
name varchar(100),
location varchar(100),
mobile int)
insert into mytable values(1,'jyo','banglore',12345)
insert into mytable values(2,'tara','hyderabad',109345)
insert into mytable values(3,'sree','goa',10945)
insert into mytable values(4,'reddy','mumbai',6785)
delete from mytable where id=1 and name='jyo'
delete from mytable where id=1 and name='sree'
delete from mytable where id=1 and name='reddy'
delete from mytable where id=1 and name='sree'
delete from mytable where id=2 and name='tara'
alter table mytable add year int
update mytable set year = 2022
update mytable set year = 2021 where name= 'jyo'
update mytable set year = 2023 where name= 'sree'
update mytable set year = 2024 where name= 'reddy'



select * from mytable