
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

    int n;

    scanf("%d", &n);

    for (int i=1;i<=n;i++) {
        printf("%d %d %.0f\n", (i), (i*i), pow(i, 3));
    }

    return 0;
}