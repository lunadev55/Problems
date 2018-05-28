#include <bits/stdc++.h>

using namespace std;

int main(){

	int x, y;

	while (scanf("%d%d",&x,&y) == 2){
		if (x == 0 && y == 0) break;

		vector <int> vecX;
		unordered_set <int> vecY;
		int total = 0;

		// adds elements to x vector
		for (int i=0;i<x;i++){
			int temp;
			scanf("%d",&temp);
			vecX.push_back(temp);
		}

		// adds elements to y vector
		for (int i=0;i<y;i++){
			int temp;
			scanf("%d",&temp);
			vecY.insert(temp);
		}

		for (int i=0;i<x;i++){
			int ans = vecX[i];
			auto search = vecY.find(ans);
			if (search != vecY.end()) total++;
		}

		printf("%d\n",total );
	}

	return 0;
}