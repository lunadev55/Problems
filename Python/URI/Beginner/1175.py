'''readMe = open('t.in','r').read
writeMe = open('t.out','w').write'''

v = []

for i in range(20):
	x = input()
	v.append(x)

a = -1
b = 20
for i in range(10):
	a += 1
	b -= 1
	temp = v[a]
	v[a] = v[b]
	v[b] = temp

for i in range(20):
	v[i] = int(v[i])
	print('N[%d] = %d' % (i,v[i]))