SELECT p.name, c.name
FROM products p
LEFT JOIN categories c ON c.id = p.id_categories
WHERE amount > 100 AND c.id IN (1, 2, 3, 6, 9)
ORDER BY c.id;