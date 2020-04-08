
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

    int x, y;

    while (scanf("%d%d",&x,&y) == 2) {
        if (x == 0 || y == 0) break;

        if (x > 0 && y > 0) {
            cout << "primeiro" << endl;
        } else if (x > 0 && y < 0) {
            cout << "quarto" << endl;
        } else if (x < 0 && y < 0) {
            cout << "terceiro" << endl;
        } else {
            cout << "segundo" << endl;
        }
    }

    
    return 0;
}