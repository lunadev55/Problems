a = 1
b = 7

xa = 0
xb = 0
for i in range(5):
	xa += 2	
	xb = 0
	if (i == 0):
		xa = 0
		#xb = 0		
	for j in range(3):		
		print('I=%d J=%d' % (a+xa,b+xb))
		xb += -1	
	