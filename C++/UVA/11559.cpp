#include <bits/stdc++.h>

using namespace std;

int main(){

	int n, b, h, w, total;

	while (scanf("%d%d%d%d",&n,&b,&h,&w) == 4){		
		int person, beds, amount=999999999;

		for (int i=0;i<h;i++){
			total = 0;
			scanf("%d",&person);
			int ans[w];
			for (int j=0;j<w;j++){
				scanf("%d",&ans[j]);
				if (ans[j] >= n) total = n*person;
			}
			if ((total < amount) && (total > 0)){
				amount = total;				
			}
		}

		if ((amount > b) || (amount == 999999999)){
			printf("stay home\n");	
		}else{
			printf("%d\n",amount );
		} 
	}

	return 0;
}
