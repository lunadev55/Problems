#include <bits/stdc++.h>

using namespace std;

int main(){

	int tc, w;
	scanf("%d",&tc);
	
	while (tc--){
		scanf("%d",&w);

		int a, b, gap;
		scanf("%d%d",&a,&b);
		gap = abs(a-b);

		bool ans = true;

		for (int i=0;i<(w-1);i++){
			scanf("%d%d",&a,&b);
			if (abs(a-b) != gap){
				ans = false;								
			}			
		}

		if (ans){
			printf("yes\n");	
		}else {
			printf("no\n");
		}

		if (tc) printf("\n");
	}


	return 0;
}