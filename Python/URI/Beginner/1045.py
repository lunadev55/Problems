from math import pow

a, b, c = input().split()

a = float(a)
b = float(b)
c = float(c)

v = [a,b,c]
v.sort()

a = v[2]
b = v[1]
c = v[0]

if ((a >= (b + c))):
	print('NAO FORMA TRIANGULO')
else:
	if ((pow(a,2) == pow(b,2) + pow(c,2))):
		print('TRIANGULO RETANGULO')
	if ((pow(a,2) > pow(b,2) + pow(c,2))):
		print('TRIANGULO OBTUSANGULO')
	if ((pow(a,2) < pow(b,2) + pow(c,2))):
		print('TRIANGULO ACUTANGULO')
	if (a == b and b == c):
		print('TRIANGULO EQUILATERO')
	if (((a == b) and (b != c)) or ((b == c) and (a != c)) or ((a==c) and (a !=c))):
		print('TRIANGULO ISOSCELES')
