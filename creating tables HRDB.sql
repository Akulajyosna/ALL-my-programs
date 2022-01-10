create database HRDB
drop table regions 
create table regions(region_id int primary key,region_name varchar(25))
drop table countries
create table countries(country_id char(2) primary key,country_name varchar(40),region_id int references regions(region_id))
create table locations(location_id int primary key,street_address varchar(25),postal_code varchar(15),city varchar(30),state_province varchar(12),country_id char(2) references countries(country_id))
create table department(department_id int primary key,deparment_name varchar(30),manager_id int,location_id int references locations(location_id))
create table job_history(employee_id int primary key,start_date date,end_date date,job_id varchar(10) references jobs(job_id),department_id int references department(department_id))
create table employees(employee_id int references job_history(employee_id),first_name varchar(20),last_name varchar(25),email varchar(25),phone_number varchar(20),hire_date date,job_id varchar(10) references jobs(job_id),salary int,commission_pct int,manager_id int,department_id int references department(department_id))
create table jobs(job_id varchar(10) primary key,job_title varchar(35),min_salary int,max_salary int)
create table job_grades(grade_level varchar(2) primary key,lowest_sal int,highest_sal int)