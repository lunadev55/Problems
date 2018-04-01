#include <bits/stdc++.h>

using namespace std;

int main(){

	int n, size, animals, frd;
	scanf("%d",&n);

	while (n--){
		int f, total = 0;
		scanf("%d",&f);

		while (f--){
			scanf("%d%d%d",&size,&animals,&frd);
			total += (size*frd);
		}
		printf("%d\n",total );
	}



	return 0;
}