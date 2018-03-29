#include <bits/stdc++.h>

using namespace std;

int main(){

	int a, b, c, d, total;

	while (scanf("%d%d%d%d",&a,&b,&c,&d),(a || b || c || d)){
		total = 0;
		//turn the dial clockwise 2 full turns
		total = 80;		
		//stop at the first number of the combination
		total += ((a-b)+40)%40;		
		//turn the dial counter-clockwise 1 full turn
		total += 40;		
		/*continue turning counter-clockwise until the 2nd
		number is reached*/
		total += ((c-b)+40)%40;		
		//turn the dial clockwise again until the 3rd number
		total += ((c-d)+40)%40;		

		int resp = (360 * total) / 40;

		printf("%d\n",resp );
	}

	return 0;
}