#average 3

a, b, c, d = input().split()

a = float(a)
b = float(b)
c = float(c)
d = float(d)

avr = ((a*2) + (b*3) + (c*4) + d)/10

exame = 0
final = 0

print("Media: %.1f" % avr)

if (avr >= 7):	
	print("Aluno aprovado.")
elif (avr < 5):	
	print("Aluno reprovado.")
else:	
	print("Aluno em exame.")
	exame = input()
	exame = float(exame)
	print("Nota do exame: %.1f" % exame)
	final = (exame + avr) / 2
	if (final >= 5):
		print("Aluno aprovado.")
	else:
		print("Aluno reprovado.")
	print("Media final: %.1f" % final)
