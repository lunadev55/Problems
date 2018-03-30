#include <bits/stdc++.h>

using namespace std;

int main(){

	int n, i=1;

	while (scanf("%d",&n),(n||0)){
		int var, a = 0, b = 0;
		while(n--){
			scanf("%d",&var);

			if (var >= 1 && var <= 99) a++;
			else b++;
		}
		printf("Case %d: %d\n",(i++),(a-b) );
	}

	return 0;
}