#include <stdio.h>
int main() {
    char a;
    scanf("%c", &a);
    if ((a >= 48)&&(a <= 57)){
        printf("digit");
    }
    else if ((a >= 65)&&(a <= 89)){
        printf("en");
    }
    else if ((a >= 97)&&(a <= 122)){
        printf("en");
    }
    else
        printf("error");
}
