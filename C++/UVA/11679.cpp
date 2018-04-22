#include <bits/stdc++.h>

using namespace std;

int main(){

	int b, n;	

	while (scanf("%d%d",&b,&n) == 2){
		if (b == 0 && n == 0) return 0;

		bool resp = true;
		int amount[b];

		for (int i=0;i<b;i++){
			scanf("%d",&amount[i]);
		}

		int c, d, v;
		while (n--){
			scanf("%d%d%d",&d,&c,&v);
			amount[(d-1)] -= v;
			amount[(c-1)] += v;
		}	 

		for (int i=0;i<b;i++){
			if (amount[i] >= 0);
			else resp = false;
		}

		if (resp) printf("S\n");
		else printf("N\n");
	}

	return 0;
}
