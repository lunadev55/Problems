#include <bits/stdc++.h>

using namespace std;

int main(){

	int tc, bigger, aux=0;
	scanf("%d",&tc);

	char url[10][103];
	int importance[10];

	while (tc--){
		bigger = 0;

		for (int i=0;i<10;i++){
			scanf("%s%d", url[i],&importance[i]);
			if (importance[i] > bigger){
				bigger = importance[i];
			}
		}

		printf("Case #%d:\n",(++aux) );

		for (int i=0;i<10;i++){
			if (importance[i] == bigger){
				printf("%s\n",url[i]);
			}
		}
	}

	return 0;
}