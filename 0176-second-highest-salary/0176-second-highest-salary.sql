SELECT
    MAX(Salary) AS SecondHighestSalary
FROM (
    SELECT Salary,
           DENSE_RANK() OVER (ORDER BY Salary DESC) AS DR
    FROM Employee
) AS t
WHERE DR = 2;

