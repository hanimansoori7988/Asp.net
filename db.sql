create database school
use school
create table  student(
id int primary key identity(1,1),
name varchar(230),
age int,
std_address text
)
select*from student