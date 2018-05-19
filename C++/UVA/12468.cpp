#include <bits/stdc++.h>

using namespace std;

int main(){

	int a, b;

	while (scanf("%d%d",&a,&b) == 2){
		if (a == -1 && b == -1) break;

		int i = a, j = b, t1 = 0, t2 = 0;

		while (i != j){					
			i--;
			t1++;
			if (i == -1) i = 99;
		}

		i = a, j = b;

		while (i != j){
			i++;
			t2++;
			if (i == 100) i = 0;
		}

		printf("%d\n",min(t1,t2) );
	}

	return 0;
}