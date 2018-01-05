even = 0
odd = 0
pos = 0
neg = 0

x = 0

for i in range(5):
	x = input()
	x = int(x)

	if (x%2==0):
		even+=1
	if (x%2==1):
		odd+=1
	if (x > 0):
		pos+=1
	if (x < 0):
		neg+=1

print("%d valor(es) par(es)" % even)
print("%d valor(es) impar(es)" % odd)
print("%d valor(es) positivo(s)" % pos)
print("%d valor(es) negativo(s)" % neg)