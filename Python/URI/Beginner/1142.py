n = input()
n = int(n)

a = 1
b = 2
c = 3
aux = 0

for i in range(n):	
	if (i == 0):
		print("%d %d %d PUM" % (a,b,c))
	else:
		print("%d %d %d PUM" % (a+aux,b+aux,c+aux))

	aux += 4
	