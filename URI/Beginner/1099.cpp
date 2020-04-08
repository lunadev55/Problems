
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

    int n, a, b, biggest, smallest, sum;
    scanf("%d", &n);

    while (n--) {
        sum = 0;

        scanf("%d%d",&a,&b);

        if (a > b) {
            smallest = b;
            biggest = a;
        } else {
            smallest = a;
            biggest = b;
        }

        for (int i=(smallest+1);i<biggest;i++){
            if (i%2!=0) sum += i;
        }

        cout << sum << endl;

    }

    
    
    return 0;
}