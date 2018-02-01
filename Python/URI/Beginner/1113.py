x, y = input().split()

x = int(x)
y = int(y)

while (x != y):
	if (x > y):
		print('Decrescente')
	else:
		print('Crescente')

	x, y = input().split()
	x = int(x)
	y = int(y)