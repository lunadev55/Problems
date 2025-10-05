SELECT p.firstName, p.lastName, a.city, a.state
FROM Person AS P
LEFT JOIN Address AS A ON A.personId = P.personId;