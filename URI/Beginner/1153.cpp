
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

int fat(int n) {
    if (n == 0) return 1;
    else {
        return n * fat(n-1);
    }
}

int main() {

    int n;
    scanf("%d", &n);

    int ret = fat(n);

    cout << ret << endl;
    
    return 0;
}