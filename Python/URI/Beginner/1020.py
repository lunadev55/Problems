import sys
from math import *

age = input()
#print (type(age))

year = age/365
r1 = age%365

month = r1/30

day = r1%30

print ('%.0f ano(s)' % year)
print ('%.0f mes(es)' % month)
print ('%.0f dia(s)' % day)

#print (str(year) + ' ano(s)')
#print (str(month) + ' mes(es)')
#print (str(r2) + ' dia(s)')

