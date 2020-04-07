
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

    int n;
    scanf("%d", &n);

    int arr[n], smallest = INT_MAX, index = 0;

    for (int i=0;i<n;i++) {
        scanf("%d", &arr[i]);
        if (arr[i] < smallest) {
            smallest = arr[i];
            index = i;
        }
    }

    printf("Menor valor: %d\n", smallest);
    printf("Posicao: %d\n", index);
    
    return 0;
}