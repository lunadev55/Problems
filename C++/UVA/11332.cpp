#include <bits/stdc++.h>

using namespace std;

int main(){

	int t, sum;
	
	while (scanf("%d",&t), (t||0)){
		sum = 0;
		
		while (1){
			while (t != 0){		
				sum += (t%10);
				t /= 10;			
			}			
			if (sum < 10) break;
			t = sum;
			sum = 0;
		}
		printf("%d\n",sum );
	}

	return 0;
}