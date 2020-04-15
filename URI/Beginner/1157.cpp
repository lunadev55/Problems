
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

int main() {

    int n;
    scanf("%d" ,&n);

    for (int i=1;i<=n;i++) {
        if (n%i == 0) {
            cout << i << endl;
        }
    }    
    
    return 0;
}