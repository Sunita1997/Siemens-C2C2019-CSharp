create procedure UpdateEmployeeRecord
@id int,
@name varchar(50),
@salary decimal(18,2),
@location varchar(50),
@deptid int,
@result int = 0 out
as
begin
declare @count int;
set @count=0;
select @count= count(employeename) from employees where employeeid=@id
if @count = 1
	begin
		update employees set employeename = @name, employeesalary = @salary, employeelocation = @location, departmentid = @deptid where employeeid=@id
		set @result=1
	end

end
