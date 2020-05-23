#include <stdio.h>
void square(int x, char c){
    int i, j;
    for (i = 0; i < x; i++)
        for (j = 0; i < x; i++)
            printf("%c", c);
    printf("\n");
}
int main(){
    int x;
    char c;
    scanf("%d %c", &x, &c);
    for (int i = 0; i < x; i++)
    square(x, c);
    return 0;
}
