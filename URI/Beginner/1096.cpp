
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

int main() {

    int v1 = 1;

    for (int i=0;i<5;i++) {
        int a = 1, v2 = 7, inner = 3;
        while (inner--) {
            cout << "I=" << v1 << " J=" << v2 << endl;
            v2--;
        }
        v1 += 2;
    }

    return 0;
}