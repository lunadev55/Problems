#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <sstream> 
#include <limits.h> // INT_MIN AND INT_MAX

#define ll long long

using namespace std;

string formatFTime(string hour, string min, string sec) {
    return hour + ':' + min + ':' + sec;
}

string convertTime(string h) {

    string hour = h.substr(0, 2);
    string min = h.substr(3, 2);
    string sec = h.substr(6, 2);
    string shift = h.substr(8, 2);
    string ret = "";

    if (hour == "12") {
        if (shift == "AM") {
            ret = formatFTime("00", min, sec);
            
        } else {
            ret = formatFTime("12", min, sec);
        }
    } else {
        if (shift == "AM") {
            ret = formatFTime(hour, min, sec);
        } else {
            stringstream ans(hour);
            int x = 0;
            ans >> x;
            x += 12;
            string str = to_string(x);
            ret = formatFTime(str, min, sec);
        }
    }

    return ret;
}

int main() {

    string h;
    cin >> h;

    cout << convertTime(h) << endl;

    
    return 0;
}