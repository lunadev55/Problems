import sys

n = input()

cem = n/100
cinquenta = (n%100) / 50
vinte = ((n%100)%50) / 20
dez = (((n%100)%50)%20) / 10
cinco = ((((n%100)%50)%20)%10) / 5
dois = (((((n%100)%50)%20)%10)%5) / 2
um = ((((((n%100)%50)%20)%10)%5)%2) 

print(n)
print ('%.0f nota(s) de R$ 100,00' % cem)
print ('%.0f nota(s) de R$ 50,00' % cinquenta)
print ('%.0f nota(s) de R$ 20,00' % vinte)
print ('%.0f nota(s) de R$ 10,00' % dez)
print ('%.0f nota(s) de R$ 5,00' % cinco)
print ('%.0f nota(s) de R$ 2,00' % dois)
print ('%.0f nota(s) de R$ 1,00' % um)