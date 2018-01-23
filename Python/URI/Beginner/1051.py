x = input()
x = float(x)

p1 = 0
p2 = 0
p3 = 0
aux = 1

if (x >= 0 and x <= 2000):
	print('Isento')
	aux = 0
elif (x > 2000 and x <= 3000):
	p1 = x - 2000
elif (x > 3000 and x <= 4500):
	p1 = 1000
	p2 = x - 3000
else:
	p1 = 1000
	p2 = 1500
	p3 = x - 4500

if (aux == 1):
	print('R$ %.2f' % ((p1*0.08) + (p2*0.18) + (p3*0.28)))