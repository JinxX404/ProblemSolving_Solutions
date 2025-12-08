#include <cmath>
class Solution {
public:
    int countTriples(int n) {
        int count = 0;

        for(int i = 1;i<=n;i++){
            for(int j = 1;j<=n;j++){

            int c = sqrt((i*i) + (j*j) + 1); 
            if(c <= n && (c*c)==((i*i) + (j*j))){
                    count++;
            }
                
            
            }
        }

    return count;

    }
};