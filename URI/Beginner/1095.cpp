#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX

#define ll long long

using namespace std;

int main() {

    int a = 0, b = 0;
    
    for (int i=0;i<13;i++) {
        printf("I=%d J=%d\n", (1+a), (60-b));
        a += 3, b += 5;
    }
    
    return 0;
}