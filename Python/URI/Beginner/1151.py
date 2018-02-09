import sys

n = input()
n = int(n)

x = [0,1]

if (n == 0):
	print('0')
elif (n == 1):
	print('1')
else:
	for i in range(n):
		if (i != 0 and i != 1):
			a = x[i-1]
			b = x[i-2]
			x.append(a+b)		

	for i in range(n):
		x[i] = str(x[i])
		if (i != (n-1)):
			sys.stdout.write(x[i])
			sys.stdout.write(' ')
		else:
			print(x[i])
