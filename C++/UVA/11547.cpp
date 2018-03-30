#include <bits/stdc++.h>

using namespace std;

int main(){
	int t, n;
	scanf("%d",&t);

	while (t--){
		scanf("%d",&n);

		n *= 567;
		n /= 9;
		n += 7492;
		n *= 235;
		n /= 47;
		n -= 498;

		printf("%d\n",abs((n%100)/10) );
	}

	return 0;
}