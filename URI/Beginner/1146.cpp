
// g++ -std=c++11 file.cpp (compile c++11)

#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX
#include <bitset>
#include <cmath>
#include <unordered_map>

#define ll long long

using namespace std;

int main() {

    int n;
    
    while (scanf("%d", &n) == 1) {
        if (n == 0)
            break;

        for (int i=1;i<=n;i++) {
            if (i == n) {
                cout << i << endl;
            } else {
                cout << i << ' ';
            }
        }
    }
    
    
    return 0;
}