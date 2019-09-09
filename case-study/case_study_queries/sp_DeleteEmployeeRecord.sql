create procedure DeleteEmployeeRecord
@id int,
@res int= 0 out
as
begin
	declare @count int;
	SELECT  @count = count(*) FROM    employees  WHERE   employeeid = @id
	if @count=1
		begin
			delete from employees where employeeid =@id
			set @res = 1
		end	
end