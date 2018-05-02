#include <bits/stdc++.h>

using namespace std;

int main(){

	int tc, j=0;
	scanf("%d",&tc);

	while (tc--){
		int n;
		scanf("%d",&n);
		int v[n], high=0, low=0;

		for (int i=0;i<n;i++){
			scanf("%d",&v[i]);
		}
		for (int i=0;i<(n-1);i++){
			if (v[i+1] > v[i]) high++;
			else if (v[i+1] < v[i]) low++;
		}

		printf("Case %d: %d %d\n",++j,high,low );
	}

	return 0;
}