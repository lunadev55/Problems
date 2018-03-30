#include <bits/stdc++.h>

using namespace std;

int main(){

	int ct=1;
	string s;
	
	while (true){
		cin >> s;

		if (s == "#") break;
		else if (s == "HELLO") printf("Case %d: ENGLISH\n",ct );
		else if (s == "HOLA") printf("Case %d: SPANISH\n",ct );
		else if (s == "HALLO") printf("Case %d: GERMAN\n",ct );
		else if (s == "BONJOUR") printf("Case %d: FRENCH\n",ct );
		else if (s == "CIAO") printf("Case %d: ITALIAN\n",ct );
		else if (s == "ZDRAVSTVUJTE") printf("Case %d: RUSSIAN\n",ct );
		else printf("Case %d: UNKNOWN\n",ct);
		ct++;
	}


	return 0;
}