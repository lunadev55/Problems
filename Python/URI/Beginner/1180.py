n = input()
n = int(n)

a = input().split()

menor = int(a[0])
pos = 0

for i in range(n):
	b = int(a[i])
	if (b < menor):
		menor = b
		pos = i

print('Menor valor:',menor)
print('Posicao:',pos)


'''num = int(input()) 

a = input().split() 

cont = 0 
c = 0 
lista = [] 
lista2 = [] 

while cont < num: 
	b = int(a[c]) 
	lista.append(b) 
	lista2.append(b) 
	c += 1 
	cont += 1 
	lista.sort() 
	print("Menor valor:",lista[0]) 
	d = lista[0] 
	print("Posicao:",lista2.index(d))'''