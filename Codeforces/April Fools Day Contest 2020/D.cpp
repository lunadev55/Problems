#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX
#include <bitset>

#define ll long long

using namespace std; // D. Again?

int main() {

    string s;
    cin >> s;

    stringstream ss;
    ss << hex << s;
    unsigned n;
    ss >> n;
    bitset<32> b(n);

    string ret = b.to_string();

    int len = ret.length();

    cout << ret.at(len-1) << endl;
    
    return 0;
}