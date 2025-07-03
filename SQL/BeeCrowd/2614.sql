SELECT customers.name, rentals.rentals_date
FROM customers
JOIN rentals ON rentals.id_customers = customers.id
WHERE EXTRACT(month from rentals.rentals_date) = 9;