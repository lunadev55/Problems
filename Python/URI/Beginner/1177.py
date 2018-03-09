n = input()
n = int(n)

v = []
aux = 0

for i in range(1000):
	if aux == n:
		aux = 0
	
	v.append(aux)

	aux += 1

for i in range(1000):
	print('N[%d] = %d' % (i,v[i]))

