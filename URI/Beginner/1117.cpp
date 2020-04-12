
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

    double mark, sum=0, ct = 0;
    
    while (scanf("%lf", &mark) == 1) {
        if (mark >= 0 && mark <= 10) {
            sum += mark;
            ct++;
            if (ct == 2) {
                printf("media = %.2lf\n", sum/2);
                break;
            }
        } else {
            cout << "nota invalida" << endl;
        }
    }
    
    
    return 0;
}