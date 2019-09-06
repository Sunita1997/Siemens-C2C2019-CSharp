declare @result int;
declare @id int;
set @id =2116
set @result = 0;
exec DeleteEmployeeRecord @id=@id, @res=@result OUTPUT
print @result


select * from employees
insert into employees values('dhananjay',23000,'bangalore',1)