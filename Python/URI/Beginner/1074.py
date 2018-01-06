n = input()
n = int(n)

for i in range(n):
	a = input()
	a = int(a)

	if (a < 0 and a%2==0):
		print('EVEN NEGATIVE')
	elif (a < 0 and a%2==1):
		print('ODD NEGATIVE')
	elif (a > 0 and a%2==0):
		print('EVEN POSITIVE')
	elif (a > 0 and a%2==1):
		print('ODD POSITIVE')
	else:
		print('NULL')