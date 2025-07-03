SELECT c.id, c.name
FROM customers AS c
WHERE c.id NOT IN (SELECT DISTINCT id_customers FROM locations);