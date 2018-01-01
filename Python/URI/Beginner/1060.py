#positive numbers

var = 0
total = 0

for i in range(6):
	var = input()
	if (var > 0): total += 1

print ('%.0f valores positivos' % total)