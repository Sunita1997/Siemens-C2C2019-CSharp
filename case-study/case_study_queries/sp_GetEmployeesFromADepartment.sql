create procedure GetEmployeesFromADepartment
@deptid int
as
begin
select * from employees where departmentid=@deptid
end