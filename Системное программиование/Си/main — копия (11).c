#include <stdio.h>
int main() {
    int b;
    char i;
    scanf("%d", &b);
    for (i = 65 + 26 - b; i < 91;i++)
        printf("%c",i);
