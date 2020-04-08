
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

    int n, ct = 0;
    cin >> n;

    int v[1000];

    for (int i=0;i<1000;i++) {
        if (ct != 0 && ct == n){
            ct = 0;
        }
        v[i] = ct;
        ct++; 
    }    

    for (int i=0;i<1000;i++) {
        printf("N[%d] = %d\n", i, v[i]);
    }
    
    return 0;
}