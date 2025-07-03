SELECT c.name 
FROM customers AS c
RIGHT JOIN legal_person as lp on lp.id_customers = c.id; 