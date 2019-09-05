create procedure DeleteEmployeeRecord
@id int
as
begin
delete from employees where employeeid=@id
end