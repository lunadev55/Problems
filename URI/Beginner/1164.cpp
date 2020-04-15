
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

bool isPerfect(int value) {
    int sum = 0;

    for (int i=1;i<value;i++) {
        if ((value%i) == 0) {
            sum += i;
        }
    }

    if (sum == value) {
        return true;
    } else {
        return false;
    }
}

int main() {

    int testCases, value;
    cin >> testCases;

    while (testCases--) {
        cin >> value;
        if (isPerfect(value)) {
            printf("%d eh perfeito\n", value);
        } else {
            printf("%d nao eh perfeito\n", value);
        }
    }
    
    
    return 0;
}