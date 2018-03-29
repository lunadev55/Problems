#include <bits/stdc++.h>

using namespace std;

int main(){

	string str;	
	int aux = 0;

	while (getline(cin, str)){
		int tam = str.length();		

		for (int i=0;i<tam;i++){
			if (str.at(i) == '"' && aux == 0){
				printf("``");
				aux = 1;
			}else if (str.at(i) == '"' && aux == 1){
				printf("''");
				aux = 0;
			}else{
				printf("%c",str.at(i) );
			}
		}
		printf("\n");
	}

	return 0;
}