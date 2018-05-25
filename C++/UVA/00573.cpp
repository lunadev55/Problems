#include <bits/stdc++.h>

using namespace std;

int main(){

	double h, u, d, f;

	while (scanf("%lf%lf%lf%lf",&h,&u,&d,&f) == 4){
		if (h == 0) break;

		int day = 1;
		double fat = u * (f/100);
		double climbed = 0;

		while (1){

			climbed += u;

			if (u > 0){				
				u -= fat;
			}

			if (climbed > h) break;
			if (climbed < 0) break;
			
			climbed -= d;
			
			if (climbed > h) break;
			if (climbed < 0) break;			

			day++;
		}

		if (climbed > h) printf("success on day %d\n",day );
		else if (climbed < 0) printf("failure on day %d\n",day );
	}

	return 0;
}