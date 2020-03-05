#include <iostream>
#include <math.h>

using namespace std;

int main(){

    int n;
    scanf("%d",&n);

    for (int i=1;i<=n;i++){
        if (i % 2 == 0){
            printf("%d^2 = %.0f\n",i, pow(i, 2));
        }        
    }

    return 0;
}