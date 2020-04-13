
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

    int code, alc = 0, gas = 0, die = 0;

    while (scanf("%d", &code) == 1) {
        if (code == 4) {
            break;
        } else {
            if (code == 1) {
                alc++;
            } else if (code == 2) {
                gas++;
            } else if (code == 3) {
                die++;
            } else {
                continue;
            }
        }
    }

    cout << "MUITO OBRIGADO" << endl;
    cout << "Alcool: " << alc << endl;
    cout << "Gasolina: " << gas << endl;
    cout << "Diesel: " << die << endl; 

    
    return 0;
}