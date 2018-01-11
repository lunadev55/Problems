x = 0
y = 0

n = input()
n = int(n)

for i in range(n):
	a = input()
	a = int(a)

	if (a >= 10 and a <= 20):
		x+=1
	else:
		y+=1

print('%d in' % x)
print('%d out' % y)