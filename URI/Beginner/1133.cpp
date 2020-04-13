
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

    int x, y, sml, big;
    scanf("%d%d", &x, &y);

    if (x > y) {
        sml = y;
        big = x;
    } else {
        sml = x;
        big = y;
    }

    for (int i=(sml+1);i<big;i++) {
        if ((i%5) == 2 || (i%5) == 3) {
            cout << i << endl;
        }
    }

    return 0;
}