x = []

for i in range(0,10):	
	a = input()
	x.append(int(a))

	if (x[i] <= 0):
		x[i] = 1

for i in range(0,10):
	print('X[%d] = %d' % (i, x[i]))

	