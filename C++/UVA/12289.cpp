#include <bits/stdc++.h>

using namespace std;

int main(){

	int t;
	scanf("%d",&t);

	while (t--){
		string str;
		cin >> str;

		if (str.length() == 5) printf("3\n");
		else{
			if ((str.at(0) == 'o' && str.at(1) == 'n') 
				|| (str.at(0) == 'o' && str.at(2) == 'e') 
				|| (str.at(1) == 'n' && str.at(2) == 'e')){
				printf("1\n");
			}else{
				printf("2\n");
			}
		}
	}


	return 0;
}