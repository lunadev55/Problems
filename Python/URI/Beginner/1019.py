import sys
from math import *

n = input()

hour = n/3600
r1 = n%3600

minute = r1/60

sec = r1%60

print ('%.0f:%.0f:%.0f' % (hour, minute, sec))

