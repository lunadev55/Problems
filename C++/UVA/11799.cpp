#include <bits/stdc++.h>

using namespace std;

int main(){

    int tc, gt = -1, ans, j=1, k;
    scanf("%d",&tc);
    
    while (tc--){
        scanf("%d",&k);
        
        for (int i=0;i<k;i++){
            scanf("%d",&ans);
            if (ans > gt) gt = ans;
        }
        
        printf("Case %d: %d\n",j++,gt);
        gt = -1;        
    }

    return 0;
}
