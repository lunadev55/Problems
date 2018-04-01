#include <bits/stdc++.h>

using namespace std;

int main(){

	int n;
	scanf("%d",&n);

	while (n--){
		string str;
		cin >> str;

		int tam = str.length();
		
		if ((str == "1") || (str == "4") || (str == "78")){
			printf("+\n");
		}else if ((str.at(tam-2) == '3') && 
			(str.at(tam-1) == '5')){
			printf("-\n");
		}else if ((str.at(0) == '9') && (str.at(tam-1) == '4')){
			printf("*\n");
		}else if ((str.at(0) == '1') && (str.at(1) == '9')
			&& (str.at(2) == '0')){
			printf("?\n");
		}
	}

	return 0;
}