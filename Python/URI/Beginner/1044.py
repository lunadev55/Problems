import sys

a, b = input().split()

a = int(a)
b = int(b)

if ((a > b) and ((a%b)==0)) or ((b > a) and ((b%a)==0)):
	print ("Sao Multiplos")
else:
	print ("Nao sao Multiplos")