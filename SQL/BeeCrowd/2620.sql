SELECT c.name, o.id 
FROM customers c
LEFT JOIN orders o ON o.id_customers = c.id
WHERE o.orders_date <= DATE('2016-06-30');