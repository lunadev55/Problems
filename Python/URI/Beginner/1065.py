even = 0

x = 0

for i in range(5):
	x = input()
	x = int(x)

	if (x%2==0):
		even+=1

print("%d valores pares" % even)
