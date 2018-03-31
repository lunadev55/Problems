#include <bits/stdc++.h>

using namespace std;

int main(){

	int tc, amount=0;
	scanf("%d",&tc);

	while (tc--){
		char temp[15];
		int n;

		scanf("%s",temp);

		if (strcmp(temp,"donate") == 0){
			scanf("%d",&n);
			amount += n;
		}else{
			printf("%d\n",amount);
		}
	}

	return 0;
}