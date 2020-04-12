
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

    int testCases;
    double x, y;

    scanf("%d",&testCases);

    while (testCases--) {

        scanf("%lf%lf",&x,&y);

        if (y == 0) {
            printf("divisao impossivel\n");
        } else if (fmod(x, y) >= 0) {
            printf("%.1lf\n", (x/y));
        } else {
            printf("divisao impossivel\n");
        }

    }

    
    return 0;
}