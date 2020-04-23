#include <stdio.h>

int main() {
    char str[100], a,b;
    int i = 0,j = 0,bg = 0,en = 0;
    gets(str);
    while (str[i] != '\0'){
        if (str[i] != ' ' && str[i - 1] == ' ' || i == 0){
            j = bg = i;
            a = str[j];
            while (str[j] != '\0'){
                if (str[j] == ' ')
                    break;
                j++;
            }
            b = str[j-1];
            en = j-1;
            if (a == b){
            while (bg <= en){
                printf("%c",str[bg]);
                bg++;
            }
            printf(" ");
            }
        }
        i++;
    }
}
