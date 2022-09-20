#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <string>
#include <math.h>

using namespace std;

int main()
{
    // possible bank notes are 100, 50, 20, 10, 5, 2, 1
    int notes;
    cin >> notes;

    cout << notes << endl;
    cout << (notes / 100) << " nota(s) de R$ 100,00" << endl;
    cout << ((notes % 100) / 50) << " nota(s) de R$ 50,00" << endl;
    cout << (((notes % 100) % 50) / 20) << " nota(s) de R$ 20,00" << endl;
    cout << ((((notes % 100) % 50) % 20) / 10) << " nota(s) de R$ 10,00" << endl;
    cout << (((((notes % 100) % 50) % 20) % 10) / 5) << " nota(s) de R$ 5,00" << endl;
    cout << ((((((notes % 100) % 50) % 20) % 10) % 5) / 2) << " nota(s) de R$ 2,00" << endl;
    cout << (((((((notes % 100) % 50) % 20) % 10) % 5) % 2) / 1) << " nota(s) de R$ 1,00" << endl;

    return 0;
}