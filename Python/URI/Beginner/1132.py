x = input()
y = input()

x = int(x)
y = int(y)

if (x > y):
	x, y = y, x

total = 0

for i in range(x,(y+1)):
	if (i % 13 != 0):
		total += i

print(total)