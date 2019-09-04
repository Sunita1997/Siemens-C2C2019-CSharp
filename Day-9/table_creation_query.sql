/*
create table departments(
departmentid int not null primary key identity(1,1),
departmentname varchar(50) not null
)
create table employees(
employeeid int primary key not null identity(100,1),
employeename varchar(50) not null,
employeesalary decimal(18,2) default(0),
employeelocation varchar(50) default('Bangalore'),
departmentid int references departments(departmentid)
)*/

--insert into departments values('HR')
--insert into departments values('Training')
--delete from departments where departmentid = 3
--insert into departments values('Resources')

--insert into employees values('anil',10000,'chennai',1)
--insert into employees values('suil',20000,'bangalore',2)
--insert into employees values('vinod',30000,'baroda',1)
--insert into employees values('banu prakash',40000,'mumbai',2)
--insert into employees values('ramnath',50000,'bangalore',1)
--insert into employees values('phaniraj',15000,'delhi',2)

--select * from employees
--select * from departments