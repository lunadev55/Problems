n = input()
n = int(n)

total = 0
_totalC = 0
_totalR = 0
_totalS = 0

for i in range(n):
	x, y = input().split()
	x = int(x)
	total += x

	if (y == 'C'):
		_totalC += x
	elif (y == 'R'):
		_totalR += x
	else:
		_totalS += x

a = (_totalC/total)*100
b = (_totalR/total)*100
c = (_totalS/total)*100


print('Total: %d cobaias' % total)
print('Total de coelhos: %d' % _totalC)
print('Total de ratos: %d' % _totalR)
print('Total de sapos: %d' % _totalS)
print('Percentual de coelhos: %.2f %%' % a)
print('Percentual de ratos: %.2f %%' % b)
print('Percentual de sapos: %.2f %%' % c)
