
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

    double m[12][12], sum = 0;
    int line; 
    char op;

    cin >> line >> op;

    for (int i=0;i<12;i++) {
        for (int j=0;j<12;j++) {
            scanf("%lf", &m[i][j]);
        }
    }

    for (int i=0;i<12;i++) {
        sum += m[line][i];
    }

    if (op == 'S') {
        printf("%.1lf\n", sum);
    } else {
        printf("%.1lf\n", (sum/12));
    }

    
    return 0;
}