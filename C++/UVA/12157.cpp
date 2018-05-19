#include <bits/stdc++.h>

using namespace std;

int main(){

	int tc, j = 0;
	scanf("%d",&tc);

	while (tc--){
		int n;
		scanf("%d",&n);
		int v[n];

		for (int i=0;i<n;i++){
			scanf("%d",&v[i]);
		}

		int mileTotal = 0;
		int juiceTotal = 0;

		//mile
		for (int i=0;i<n;i++){
			int aux = v[i], total = 0;
			for (int j=0;j<=aux;j+=29){				
				j++;
				total++;
			}
			mileTotal += total * 10;
		}

		//juice
		for (int i=0;i<n;i++){
			int aux = v[i], total = 0;
			for (int j=0;j<=aux;j+=59){				
				j++;
				total++;
			}
			juiceTotal += total * 15;
		}
		
		if (mileTotal < juiceTotal){
			printf("Case %d: Mile %d\n",(++j), mileTotal );
		}else if (juiceTotal < mileTotal){
			printf("Case %d: Juice %d\n",(++j), juiceTotal );
		}else{
			printf("Case %d: Mile Juice %d\n",(++j), mileTotal );
		}		
	}

	return 0;
}