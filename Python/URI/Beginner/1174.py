a = []

for i in range(100):
	x = input()
	x = float(x)

	a.append(x)

for i in range(100):
	if (a[i] <= 10):
		print('A[%d] = %.1f' % (i,a[i]))