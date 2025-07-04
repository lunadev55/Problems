SELECT prod.name, prov.name, prod.price
FROM products prod
LEFT JOIN providers prov ON prov.id = prod.id_providers
LEFT JOIN categories c ON c.id = prod.id_categories
WHERE prod.price > 1000 AND c.name = 'Super Luxury';