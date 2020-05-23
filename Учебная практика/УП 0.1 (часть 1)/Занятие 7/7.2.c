/**
Напишите программу-калькулятор для четырёх основных арифметических действий.
Работа выполнена 16.12.18 студентом группы П2-16 Вологузовым В.В.
*/
#include <stdio.h>
int main() {
    int a, b;
    char c;
    scanf("%d %d %c",&a,&b,&c);
    switch(c){
        case '+':printf("%.2lf",(double)a+b); break;
        case '-':printf("%.2lf",(double)a-b); break;
        case '*':printf("%.2lf", (double)a*b); break;
        case '/':
          switch (b) {
                default:printf("%.2f",(double)a/b); break;
                 case 0:printf("ERROR!"); break;
                    }
         break;
        default:printf("ERROR!");
    }
  return 0;
}
