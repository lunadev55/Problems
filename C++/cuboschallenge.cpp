#include <iostream>
#include <string>
#include <vector>
#include <sstream>
#include <stdlib.h>

using namespace std;

int main() {
    
    long long int groups[4];

    for (int i=0;i<4;i++) {
        scanf("%lld", &groups[i]);
    }

    long long int singleGroups = (groups[0] * 1);
    long long int groupsOfTwo = (groups[1] * 2);
    long long int groupsOfThree = (groups[2] * 3);
    long long int groupsOfFour = (groups[3] * 4);

    long long int totalOfPeople = singleGroups +
                                    groupsOfTwo +
                                        groupsOfThree + 
                                            groupsOfFour;

    
    long long int result = totalOfPeople / 4;
    long long int rest = totalOfPeople % 4;

    if (rest == 0) {
        cout << result << endl;
    } else {
        cout << (result + 1) << endl;
    }
    
    return 0;
}

