#include<stdio.h>
int main() {
    int n, i, j, x = 0, y = 0,temp = 0, digit = 1;
    char str[100];

    scanf("%d", &n);
    for (i = 0; i <= n; i++) {
        gets(str);
        for (j = 0;str[j]!='\0';j++){
            if ((str[j]>= 48)&&(str[j]<=57)){
                if (digit > 1)
                    temp*=10;
                temp += str[j] - 48;
                digit++;
            }
        }
        for (j = 0;str[j]!='\0';j++){
        switch(str[j]){
            case 'N': y+=temp;break;
            case 'E': x += temp;break;
            case 'S': temp*= -1; y += temp;break;
            case 'W': temp*= -1; x += temp;break;
            }
        }
        temp = 0;
    }
    printf("%d %d",x,y);
}
