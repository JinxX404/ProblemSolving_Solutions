select Department, Employee , Salary 
from (
    select dep.name as Department ,emp.name as Employee ,emp.salary as Salary,
dense_rank() over(partition by departmentId order by salary desc) as DR
from Employee emp join Department dep 
on dep.id = emp.departmentId 
) as newtable
where DR <= 3