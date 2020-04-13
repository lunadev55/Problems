
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

    double n[100], value;

    scanf("%lf", &value);

    n[0] = value;
    printf("N[0] = %.4lf\n", value);

    for (int i=1;i<100;i++) {
        n[i] = n[i-1] / 2;
        printf("N[%d] = %.4lf\n", i, n[i]);
    }

    return 0;
}