import sys
from math import *

spent = input()
speed = input()

distance = int(spent) * int(speed)
total = float(distance) / 12.0

print ('%.3f' % total)