
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

    int testCases, amount, sumCoelho=0, sumRato=0, sumSapo=0;
    int globalSum = 0;
    char animal;

    scanf("%d", &testCases);

    while (testCases--) {
        cin >> amount >> animal;

        if (animal == 'C') {
            sumCoelho += amount;
        } else if (animal == 'R') {
            sumRato += amount;
        } else {
            sumSapo += amount;
        }

        globalSum += amount;
    }


    printf("Total: %d cobaias\n", globalSum);

    printf("Total de coelhos: %d\n", sumCoelho );
    printf("Total de ratos: %d\n", sumRato);
    printf("Total de sapos: %d\n", sumSapo);

    printf("Percentual de coelhos: %.2lf %%\n", (sumCoelho*100.0)/globalSum);
    printf("Percentual de ratos: %.2lf %%\n", (sumRato*100.0)/globalSum);
    printf("Percentual de sapos: %.2lf %%\n", (sumSapo*100.0)/globalSum);

    
    
    return 0;
}