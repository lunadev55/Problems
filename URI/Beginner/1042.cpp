#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <string>
#include <math.h>

using namespace std;

int main()
{
    int num1, num2, num3;
    cin >> num1 >> num2 >> num3;

    if (num1 > num2 && num1 > num3)
    {
        if (num2 > num3)
        {
            cout << num3 << endl
                 << num2 << endl;
        }
        else
        {
            cout << num2 << endl
                 << num3 << endl;
        }
        cout << num1 << endl;
    }
    else if (num2 > num1 && num2 > num3)
    {
        if (num1 > num3)
        {
            cout << num3 << endl
                 << num1 << endl;
        }
        else
        {
            cout << num1 << endl
                 << num3 << endl;
        }
        cout << num2 << endl;
    }
    else if (num3 > num1 && num3 > num2)
    {
        if (num1 > num2)
        {
            cout << num2 << endl
                 << num1 << endl;
        }
        else
        {
            cout << num1 << endl
                 << num2 << endl;
        }
        cout << num3 << endl;
    }

    cout << endl;

    cout << num1 << endl
         << num2 << endl
         << num3 << endl;

    return 0;
}