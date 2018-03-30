#include <bits/stdc++.h>

using namespace std;

int main(){

	int k, n, m, a, b;

	while (scanf("%d",&k) == 1){
		if (k == 0) break;
		scanf("%d%d",&n,&m);

		while (k--){
			scanf("%d%d",&a,&b);

			if (a == n || b == m) printf("divisa\n");
			else if (a > n && b > m) printf("NE\n");
			else if (a > n && b < m) printf("SE\n");
			else if (a < n && b > m) printf("NO\n");
			else if (a < n && b < m) printf("SO\n");
		}
	}

	return 0;
}