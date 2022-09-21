#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <string>
#include <math.h>

using namespace std;

int main()
{
    double a, b, c;
    cin >> a >> b >> c;

    double delta = pow(b, 2) - (4 * a * c);

    if (delta < 0 || delta == 0 || a == 0.0)
    {
        cout << "Impossivel calcular" << endl;
    }
    else
    {
        double raiz1 = ((b * (-1)) + sqrt(delta)) / (2 * a);
        double raiz2 = ((b * (-1)) - sqrt(delta)) / (2 * a);

        printf("R1 = %.5lf\n", raiz1);
        printf("R2 = %.5lf\n", raiz2);
    }

    return 0;
}