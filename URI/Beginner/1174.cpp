
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

    double arr[100];

    for (int i=0 ; i<100; i++) {
        scanf("%lf",&arr[i]);     
        if (arr[i] <= 10) {
            printf("A[%d] = %.1lf\n", i, arr[i]);
        }   
    }
    
    return 0;
}