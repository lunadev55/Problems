SELECT prod.name
FROM products prod
LEFT JOIN providers prov ON prov.id = prod.id_providers
WHERE LEFT(prov.name, 1) = 'P' AND prod.amount BETWEEN 10 AND 20;