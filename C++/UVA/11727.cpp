#include <bits/stdc++.h>

using namespace std;

int main(){

	int tc, v[3];
	scanf("%d",&tc);

	for (int i=0;i<tc;i++){
		scanf("%d%d%d",&v[0],&v[1],&v[2]);
		sort(v,v+3);
		printf("Case %d: %d\n",(i+1),v[1] );
	}

	return 0;
}