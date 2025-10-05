SELECT e.name AS Employee FROM Employee AS e
WHERE e.salary > (SELECT TOP 1 e2.salary FROM Employee AS e2 WHERE e2.id = e.managerId);