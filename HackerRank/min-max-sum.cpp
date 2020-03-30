#include <stdio.h>
#include <stdlib.h>
#include <limits.h>

#define ll long long

using namespace std;

void function(int *n) {
    ll max = INT_MIN, min = INT_MAX, total = 0;

    for (int i=0;i<5;i++) {
        if (n[i] > max) {
            max = n[i];
        }
        if (n[i] < min) {
            min = n[i];
        }
        total += n[i];
    }

    printf("%lld %lld\n", (total-max), (total-min));
}

int main() {
    
    int n[5];

    for (int i=0;i<5;i++) {
        scanf("%d",&n[i]);
    }

    function(n);

    return 0;
}