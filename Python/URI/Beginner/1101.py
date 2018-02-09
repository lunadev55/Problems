import sys

n, m = input().split()
n = int(n)
m = int(m)

while (n > 0 and m > 0):
	total = 0

	if (n > m):
		n, m = m, n

	for i in range(n,(m+1)):
		total += i
		temp = i
		temp = str(temp)
		sys.stdout.write(temp)
		sys.stdout.write(' ')
	
	print('Sum=%d' % total)
	
	n, m = input().split()
	n = int(n)
	m = int(m)
