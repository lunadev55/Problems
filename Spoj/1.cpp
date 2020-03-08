#include <iostream>

using namespace std;

int main(){

    int n;
    
    while (scanf("%d",&n) == 1){
        if (n == 42) return 0;
        printf("%d\n",n);
    }


    return 0;
}