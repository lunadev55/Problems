
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

    int a, b;

    while (scanf("%d%d", &a, &b) == 2){
        if (a == b) {
            break;
        } else if (a > b) {
            cout << "Decrescente" << endl;
        } else {
            cout << "Crescente" << endl;
        }
    }


    
    return 0;
}