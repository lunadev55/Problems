#include <bits/stdc++.h>

using namespace std;

char a[100];

int main(){

	int tc;
	scanf("%d",&tc);

	while (tc--){
		int z, x = 0, i = 0;
		scanf("%d",&z);

		int v[z];

		while (z--){
			scanf("%s",a);

			if (strcmp(a,"LEFT") == 0){
				x--;
				v[i] = -1;
			}else if (strcmp(a,"RIGHT") == 0){
				x++;
				v[i] = +1;
			}else if (strcmp(a,"SAME") == 0){
				char aux[3];
				scanf("%s",aux);
				int cmd;
				scanf("%d",&cmd);
				x += v[cmd-1];
				v[i] = v[cmd-1];
			}
			i++;			
		}
		printf("%d\n",x );
	}

	return 0;
}