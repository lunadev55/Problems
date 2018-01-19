x = input()
y = input()

x = int(x)
y = int(y)

if (y > x):
	x, y = y, x

t = 0

for i in range((y+1),x):	
	'''print('i =',i)'''
	if (i%2==1):
		'''print('i =',i)'''
		t += i

print(t)