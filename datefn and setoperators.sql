create database datefn
select getdate()
select day('2021-09-01');
select year('2020-01-11');
select month('2002-01-08');
select datepart(year, '2020/05/01 14:38:52') as year_, 
	datepart(month, '2020/04/01 14:38:52') as month_, 
	datepart(day, '2020/03/01 14:38:52') as day_, 
	datepart(hour, '2020/02/01 14:38:52') as hour_, 
	datepart(minute, '2020/01/01 14:38:52') as minute_, 
	datepart(second, '2020/05/01 14:38:52') as second_;
select DATEFROMPARTS(2020,5,1) as _date;
select DATEADD(day, -10, '2020-05-01') as _date_add;
select DATEDIFF(day, '2020-05-01', '2020-05-10') as _date_difference;
select eomonth('2020-05-01') as _eom;
--select current_timezone()
SELECT DATENAME(year, '12:10:30.123')  
    ,DATENAME(month, '12:10:30.123')  
    ,DATENAME(day, '12:10:30.123')  
    ,DATENAME(dayofyear, '12:10:30.123')  
    ,DATENAME(weekday, '12:10:30.123');
declare @datetime2 datetime2 = '2007-01-01 13:10:10.1111111' 
SELECT 'year', DATEADD(year,1,@datetime2) as col  
union all
SELECT 'month',DATEADD(month,1,@datetime2) as dat 
drop table data
create table data(clgid int,clgname varchar(20),clglocation varchar(20))
insert into data values(1,'jaya','blg')
insert into data values(2,'sree','ap')
insert into data values(3,'juntua','tm')
insert into data values(4,'jntuh','hyb')
insert into data values(5,'jaya','dmm')
select * from data
create table data1(clgid int,clgcode int,clgdist varchar(20))
insert into data1 values(5,005,'blg')
insert into data1 values(2,009,'ap')
insert into data1 values(1,006,'tm')
insert into data1 values(4,987,'hyb')
insert into data1 values(9,009,'dmm')

select * from data1
select clgid from data
union 
select clgid from data1
select clgid from data
union all
select clgid from data1
select clgid from data
intersect 
select clgid from data1
select clgid from data
except
select clgid from data1



 