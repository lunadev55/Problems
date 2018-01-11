a = input()
a = int(a)

maior = a
pos = 0

for i in range(99):
	a = input()
	a = int(a)

	if (a > maior):
		maior = a
		pos = (i+2)

print(maior)
print(pos)