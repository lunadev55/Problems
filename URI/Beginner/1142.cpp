
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

    int n, a=1, b=2, c=3;
    scanf("%d", &n);

    while (n--) {
        cout << a << ' ' << b << ' ' << c << " PUM" << endl;
        a += 4, b += 4, c+= 4;
    }
    
    
    return 0;
}