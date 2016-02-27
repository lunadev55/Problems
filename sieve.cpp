#include <bits/stdc++.h>
#define ll long long 
#define MAX 1000000

using namespace std;

//sieve working totally fine

bool crivo[MAX];

void processa(){
    crivo[0] = 0;
    crivo[1] = 0;
    
    for (int i=2;i<sqrt(MAX);i++){
        if (crivo[i] == 1){
            for (ll j=i*i;j<MAX;j+=i) crivo[j] = 0;            
        }
    }
}

int main(){

    //freopen("t.out","w",stdout);

    vector<int> v;    
    memset(crivo, 1, sizeof(crivo));    
    processa();
    
    for (int i=0;i<MAX;i++){
        if (crivo[i] == 1) v.push_back(i);
    }
    
    int n, l;
    
    scanf("%d",&n);
    
    while (n--){
        scanf("%d",&l);
        printf("%d\n",v[l-1]);        
    }
    
    return 0;
}
