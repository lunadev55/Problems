#include <iostream>
#include <string>
#include <vector>
#include <sstream>
#include <stdlib.h>

using namespace std;

int jumpingOnClouds(vector<int> c) {
    int counter = 0, i = 0;

    while (i < (c.size() - 1)) {
        if (c[i + 2] == 0) {
            counter++;
            i += 2;
        } else {
            counter++;
            i += 1;
        }       
    }

    return counter;
}

int main() {

    int numberOfClouds, cloudType;
    cin >> numberOfClouds;

    vector<int> cloud;

    for (int i=0; i<numberOfClouds; i++) {
        cin >> cloudType;
        cloud.push_back(cloudType);
    }   

    cout << jumpingOnClouds(cloud) << endl;    
    
    return 0;
}

