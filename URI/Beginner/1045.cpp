#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {

    vector<double> v;
    double n;

    for (int i=0;i<3;i++){
        cin >> n;
        v.push_back(n);
    }

    sort(v.begin(), v.begin() + 3);

    double a = v[2], b = v[1], c = v[0];

    if (a >= (b + c)) {
        printf("NAO FORMA TRIANGULO\n");
        return 0;
    }
    if (a*a == (b*b + c*c)) printf("TRIANGULO RETANGULO\n");
    if (a*a > (b*b + c*c)) printf("TRIANGULO OBTUSANGULO\n");
    if (a*a < (b*b + c*c)) printf("TRIANGULO ACUTANGULO\n");
    if (a == b && b == c) printf("TRIANGULO EQUILATERO\n");
    if ((a == b && b != c) || (a == c && c != b) || (b == c && c != a)) printf("TRIANGULO ISOSCELES\n");


    return 0;
}