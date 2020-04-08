
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

    int x, y, sum = 0;
    scanf("%d%d", &x, &y);

    int biggest, smallest;

    if (x > y){
        biggest = x;
        smallest = y;
    } else {
        biggest = y;
        smallest = x;
    }

    for (int i=x;i<=y;i++) {
        if (i % 13 != 0) {
            sum += i;
        }
    }

    cout << sum << endl;
    
    return 0;
}