#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX

#define ll long long

using namespace std;

int main() {

    int n[20];

    for (int i=0;i<20;i++)
        scanf("%d", &n[i]);

    int a = 0;
    for (int i=19;i>=0;i--) {
        printf("N[%d] = %d\n", a, n[i]);
        a++;
    }

    
    return 0;
}