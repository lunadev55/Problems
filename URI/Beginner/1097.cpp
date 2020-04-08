
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

    int ii = 1, jj = 7, ans = jj;

    for (int i=0;i<5;i++) {
        for (int j=0;j<3;j++) {
            printf("I=%d J=%d\n", ii, ans);
            ans--;
        }
        ii += 2;
        jj += 2;
        ans = jj;
    }    

    return 0;
}