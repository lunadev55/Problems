n = input()
n = int(n)

for i in range(n):
	x, y = input().split()
	x = int(x)
	y = int(y)

	if (x > y):
		x, y = y, x

	total = 0

	for j in range((x+1),y):
		if (j%2==1):
			total += j

	print(total)
	
		