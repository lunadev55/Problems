
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

    int m, n;
    
    while (scanf("%d%d",&m,&n) == 2) {
        if (m <= 0 || n <= 0) break;

        int sum = 0, biggest, smallest;

        if (m > n) {
            biggest = m;
            smallest = n;
        } else {
            biggest = n;
            smallest = m;
        }

        for (int i=smallest;i<=biggest;i++) {
            sum += i;
            cout << i << ' '; 
        }

        cout << "Sum=" << sum << endl;
    }


    
    return 0;
}