#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {

    int n, x;
    scanf("%d", &x);

    while (x--){
        scanf("%d",&n);

        if (n == 0){
            printf("NULL\n");
        } else if (n%2==0){
            if (n > 0){
                printf("EVEN POSITIVE\n");
            } else {
                printf("EVEN NEGATIVE\n");
            }            
        } else if (n%2!=0) {
            if (n > 0) {
                printf("ODD POSITIVE\n");
            } else {
                printf("ODD NEGATIVE\n");
            }
        }
    }
    
    return 0;
}