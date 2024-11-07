SELECT p.id, p.name
FROM products as p
LEFT JOIN categories as c on p.id_categories = c.id
WHERE c.name LIKE 'super%';