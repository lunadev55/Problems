#include <bits/stdc++.h>

using namespace std;

int main(){

	int n, ct=0, total=0;
	scanf("%d",&n);

	string test;
	cin >> test;

	stack <char> mystack;

	for (int i=0;i<n;i++){
		char temp = test.at(i);
		mystack.push(temp);
		if (temp == 'x') ct++;
		if (temp != 'x') ct = 0;
		if (ct == 3){
			mystack.pop();
			ct--;
			total++;
		}
	}

	printf("%d\n",total );

	return 0;
}