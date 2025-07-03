SELECT prod.name, prov.name, c.name
FROM products AS prod
LEFT JOIN providers AS prov ON prov.id = prod.id_providers
LEFT JOIN categories AS c ON c.id = prod.id_categories
WHERE prov.name = 'Sansul SA' AND c.name = 'Imported';