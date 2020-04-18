
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

    while (scanf("%d", &n) == 1) {
        if (n == 0)
            break;

        int count = 0, sum = 0;

        while (count < 5) {
            if (n%2==0) {
                sum += n;
                count++;
            }
            n++;
        }

        cout << sum << endl;
    }

    
    
    return 0;
}