
// g++ -std=c++11 file.cpp (compile c++11)

#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX
#include <bitset>
#include <cmath>

#define ll long long

using namespace std;

int singleNumber(vector<int>& nums) {
    int x = 0;

    for (int i : nums) {
        x ^= i;
    }

    return x;
}

int main() {

    vector<int> n = {2, 1, 3, 2 , 3};

    cout << singleNumber(n) << endl;

    return 0;
}