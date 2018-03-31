#include <bits/stdc++.h>

using namespace std;

int main(){

	char str[10];
	int i=1;

	while (scanf("%s",str) == 1){
		if (strcmp(str, "*") == 0) return 0;
		else{
			if (strcmp(str, "Hajj") == 0){
				printf("Case %d: Hajj-e-Akbar\n",(i++));
			}else{
				printf("Case %d: Hajj-e-Asghar\n",(i++));
			}
		}
	}

	return 0;
}