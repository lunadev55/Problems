import sys

a, b, c = input().split()

a = int(a)
b = int(b)
c = int(c)

v = [a,b,c]

v.sort()

print(v[0])
print(v[1])
print(v[2])
print('')
print(a)
print(b)
print(c)
