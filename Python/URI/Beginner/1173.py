n = input()
n = int(n)

a = []
a.append(n) 

for i in range(1,10):
	a.append(a[i-1]*2)

for i in range(0,10):
	print('N[%d] = %d' % (i,a[i]))
