
// g++ -std=c++11 file.cpp (compile c++11)

#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX
#include <bitset>
#include <cmath>

#define ll long long

using namespace std;

vector<int> fib(vector<int> ret, int n) {
    ret.push_back(0);
    ret.push_back(1);

    for (int i=2;i<n;i++) {
        ret.push_back(ret.at(i-1) + ret.at(i-2));
    }

    return ret;
}

int main() {

    int n;
    scanf("%d", &n);

    vector<int> r;

    r = fib(r, n);

    for (int i=0;i<r.size();i++) {
        if (i == (r.size() - 1)) {
            cout << r.at(i) << endl;
            break;
        }
        cout << r.at(i) << " ";         
    }  
    
    return 0;
}