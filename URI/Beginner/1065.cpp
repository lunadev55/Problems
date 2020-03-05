#include <iostream>

using namespace std;

int main(){
    
    int var, pares = 0;

    for (int i=0;i<5;i++){
        scanf("%d",&var);
        
        if (var % 2 == 0){
            pares++;
        } 
    }

    printf("%d valores pares\n",pares);

    return 0;
}