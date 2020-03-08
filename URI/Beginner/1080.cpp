#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {

    int v[100], bigger = 0, index;

    for (int i=0;i<100;i++) {
        scanf("%d",&v[i]);

        if (v[i] > bigger) {
            bigger = v[i];
            index = i;
        }
    }

    printf("%d\n%d\n",bigger, (index + 1));
    
    return 0;
}