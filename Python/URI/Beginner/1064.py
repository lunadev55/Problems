#odd numbers

ct = 0
total = 0

for i in range(1,7):
	x = input()
	x = float(x)

	if (x > 0):
		ct+=1
		total+=x

print("%d valores positivos" % ct)
print("%.1f" % (total/ct))