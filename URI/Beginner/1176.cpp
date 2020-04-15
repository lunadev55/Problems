
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

vector<ll> fib() {
    vector<ll> fibo;

    fibo.push_back(0);
    fibo.push_back(1);

    for (int i=2;i<=60;i++) {
        ll value = (fibo[i-1] + fibo[i-2]);

        fibo.push_back(value);
    }

    return fibo;
}

int main() {

    vector<ll> f = fib();

    int testCases, n;
    cin >> testCases;    

    while (testCases--) {
        cin >> n;
        printf("Fib(%d) = %lld\n", n, f[n]); 
    }       
    
    return 0;
}