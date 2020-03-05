#include <iostream>

using namespace std;

int main() {

    int x;
    scanf("%d", &x);

    int odd = 0;

    while (odd < 6) {
        if (!(x % 2 == 0)) {
            printf("%d\n",x);
            odd++;
        }
        x = x + 1;
    }

    return 0;
}