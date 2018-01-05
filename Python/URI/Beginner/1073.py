n = input()
n = int(n)

for i in range(1,n+1):
	if (i%2==0):
		print("%d^2 = %d" % (i,i*i))