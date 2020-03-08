#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {

    int x, num, in = 0, out = 0;

    scanf("%d",&x);

    while (x--) {
        scanf("%d",&num);

        if (num >= 10 && num <= 20) {
            in++;
        } else {
            out++;
        }
    }

    printf("%d in\n%d out\n", in, out);
        
    return 0;
}