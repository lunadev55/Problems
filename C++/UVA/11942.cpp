#include <bits/stdc++.h>

using namespace std;

int main(){

	int n;
	scanf("%d",&n);
	int temp = n;

	while (n--){

		int ans[10], maior = 0, menor = 0;

		for (int i=0;i<10;i++){
			scanf("%d",&ans[i]);
		}
		for (int i=0;i<9;i++){
			if (ans[i+1] > ans[i]) maior++;
			else menor++;
		}

		if (n == (temp-1)) printf("Lumberjacks:\n");

		if (maior == 9 || menor == 9){
			printf("Ordered\n");
		}else{
			printf("Unordered\n");
		}
	}

	return 0;
}