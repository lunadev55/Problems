#include <bits/stdc++.h>

using namespace std;

int main(){
	
	int n;

	scanf("%d",&n);

	while (1){	

		string name;
		string v[n];

		map <string, int> friends;

		for (int i=0;i<n;i++){		
			cin >> name;
			v[i] = name;
			friends[name] = 0;
		}

		for (int i=0;i<n;i++){
			// current friend		
			cin >> name;	

			// value he/she spends on given-gifts
			int amount;
			scanf("%d",&amount);

			// quantity of friends he/she gives gifts
			int numberF;
			scanf("%d",&numberF);		

			if (numberF > 0){
				int ans = amount / numberF;
				friends[name] -= (ans * numberF);

				for (int j=0;j<numberF;j++){
					cin >> name;
					friends[name] += ans;
				}
			}
		}

		for (int i=0;i<n;i++){
			for (map <string, int> :: iterator j = friends.begin();
					j != friends.end(); j++){
				if ((j->first) == v[i]){
					cout << j -> first << ' ' << j -> second << endl;
				}			
			}
		}

		if (cin >> n)
			printf("\n");
		else
			break;
	}

	return 0;
}