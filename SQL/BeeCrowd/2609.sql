SELECT c.name, SUM(p.amount)
FROM products as p
LEFT JOIN categories as c on c.id = p.id_categories
GROUP BY c.name;