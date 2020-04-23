#include <stdio.h>
int main() {
    char str[10];
    int i = 0,sum1 = 0,sum2 = 0;
    gets(str);
    while (i < 3){
        sum1+=str[i];
        i++;
    }
    while(i < 7){
        sum2+=str[i];
        i++;
    }
    printf(sum1 == sum2 ? "yes":"no");
