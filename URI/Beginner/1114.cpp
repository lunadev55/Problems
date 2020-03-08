#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {

    int code;
    
    while (scanf("%d",&code) == 1){
        if (code == 2002) {
            printf("Acesso Permitido\n");
            break;
        }
        printf("Senha Invalida\n");
    }

    
    return 0;
}