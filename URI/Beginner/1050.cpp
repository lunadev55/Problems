#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <string>
#include <math.h>
#include <iomanip>

using namespace std;

int main()
{
    int stateCode;
    cin >> stateCode;

    if (stateCode == 61)
    {
        cout << "Brasilia" << endl;
    }
    else if (stateCode == 71)
    {
        cout << "Salvador" << endl;
    }
    else if (stateCode == 11)
    {
        cout << "Sao Paulo" << endl;
    }
    else if (stateCode == 21)
    {
        cout << "Rio de Janeiro" << endl;
    }
    else if (stateCode == 32)
    {
        cout << "Juiz de Fora" << endl;
    }
    else if (stateCode == 19)
    {
        cout << "Campinas" << endl;
    }
    else if (stateCode == 27)
    {
        cout << "Vitoria" << endl;
    }
    else if (stateCode == 31)
    {
        cout << "Belo Horizonte" << endl;
    }
    else
    {
        cout << "DDD nao cadastrado" << endl;
    }

    return 0;
}