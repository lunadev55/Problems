#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX

#define ll long long

using namespace std;

int main() {

    int n;
    scanf("%d",&n);

    while (n--) {

        double a, b, c;

        scanf("%lf%lf%lf", &a, &b, &c);
        printf("%.1lf\n", ((a*2) + (b*3) + (c*5)) / (2+3+5));

    }
    
    return 0;
}