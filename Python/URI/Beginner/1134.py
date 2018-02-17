x = input()
x = int(x)

alc = 0
gas = 0
die = 0

while (x != 4):
	if (x == 1):
		alc += 1
	elif (x == 2):
		gas += 1
	elif (x == 3):
		die += 1
	x = input()
	x = int(x)

print('MUITO OBRIGADO')
print('Alcool: %d' % alc)
print('Gasolina: %d' % gas)
print('Diesel: %d' % die)