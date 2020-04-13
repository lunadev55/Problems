
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

    double age, sum = 0;
    int counter = 0;

    while (scanf("%lf" ,&age) == 1) {
        if (age > 0) {
            sum += age;
            counter++;
        } else {
            break;
        }
    }

    printf("%.2lf\n", (sum/counter));
    
    return 0;
}