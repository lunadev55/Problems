n = input()
n = int(n)

while (n > 0):
	n -= 1

	a, b, c = input().split()
	a = float(a)
	b = float(b)
	c = float(c)

	total = a*2 + b*3 + c*5

	print('%.1f' % (total/10))