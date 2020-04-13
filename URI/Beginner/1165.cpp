
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

int isPrime(int n) {
    int ct = 0;
    for (int i=1;i<=floor(sqrt(n));i++) {
        if ((n%i) == 0) {
            ct++;
        }
    }
    return ct; 
}

int main() {

    int testCases, n;
    scanf("%d",&testCases);

    while (testCases--) {
        scanf("%d", &n);
        int ans = isPrime(n);

        if (ans == 1) {
            cout << n << " eh primo" << endl;
        } else {
            cout << n << " nao eh primo" << endl;
        }
    }

    return 0;
}