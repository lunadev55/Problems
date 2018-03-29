#include <bits/stdc++.h>

using namespace std;

int main(){

	int t, stores;

	scanf("%d",&t);

	while (t--){
		scanf("%d",&stores);
		int pos, bigger=0, smaller=100;
		while (stores--){
			scanf("%d",&pos);
			if (pos > bigger) bigger = pos;
			if (pos < smaller) smaller = pos;
		}
		
		int result = (bigger-smaller) * 2;
		printf("%d\n", result);
	}

	return 0;
}