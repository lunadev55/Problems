n = input()
n = int(n)

total = 1

for i in range(n, 1, -1):
	total *= i
	
print(total)