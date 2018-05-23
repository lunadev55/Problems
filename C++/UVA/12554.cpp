#include <bits/stdc++.h>

using namespace std;

int main(){

	string song[16];
	song[0] = "Happy";
	song[1] = "birthday";
	song[2] = "to";
	song[3] = "you";
	song[4] = "Happy";
	song[5] = "birthday";
	song[6] = "to";
	song[7] = "you";
	song[8] = "Happy";
	song[9] = "birthday";
	song[10] = "to";
	song[11] = "Rujia";
	song[12] = "Happy";
	song[13] = "birthday";
	song[14] = "to";
	song[15] = "you";

	int n;
	scanf("%d",&n);	

	string names[n];

	for (int i=0;i<n;i++){
		cin >> names[i];		
	}
	
	int k = 0;

	while (k < n) {
		for (int i=0; i<16; i++,k++){
			cout << names[k%n] + ": " << song[i] << endl;
		}
	}

	return 0;
}