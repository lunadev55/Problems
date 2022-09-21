#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <string>
#include <math.h>

using namespace std;

int main()
{
    int x, y;
    cin >> x >> y;

    double products[6] = {0.00, 4.00, 4.50, 5.00, 2.00, 1.50};

    printf("Total: R$ %.2lf\n", (y * products[x]));

    return 0;
}