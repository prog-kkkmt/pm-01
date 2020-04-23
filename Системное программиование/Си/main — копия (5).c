#include<stdio.h>
int sequence_multipliers(int k){
    int i;
    for (i = 0;i < k;i++){
        if (i * (i + 1) * (i + 2) == k)
            return i;
    }
    return -1;

}
int main(){
    int k;
    scanf("%d", &k);
    printf("%d", sequence_multipliers(k));
