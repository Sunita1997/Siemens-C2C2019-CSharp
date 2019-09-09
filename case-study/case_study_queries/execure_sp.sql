
declare @result int;
declare @id int;
set @id =3102;
exec DeleteEmployeeRecord @id=@id, @res=@result OUTPUT
print @result


select * from employees
use siemensdb;
insert into employees values('dhananjay',23000,'bangalore',1)