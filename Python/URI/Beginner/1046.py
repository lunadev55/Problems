#game time

x, y = input().split()

x = int(x)
y = int(y)

if (x == y):
	print("O JOGO DUROU 24 HORA(S)")
else:
	z = (((24-x)+y)%24)
	print("O JOGO DUROU %d HORA(S)" % z)