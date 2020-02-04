#include <cstdio>
#include <cstdlib>

using namespace std;

int main(){

    int par = 0, impar = 0, pos = 0, neg = 0, val = 0;

    // scanf("%d",&val);

    for (int i=0;i<5;i++){        
        scanf("%d",&val);
        
        if (val % 2 == 0) par++;
        else impar++;

        if (val > 0) pos++;
        else if (val < 0) neg++;
    } 

    printf("%d valor(es) par(es)\n", par);
    printf("%d valor(es) impar(es)\n", impar);
    printf("%d valor(es) positivo(s)\n", pos);
    printf("%d valor(es) negativo(s)\n", neg);

    return 0;
}