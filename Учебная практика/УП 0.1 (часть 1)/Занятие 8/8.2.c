/**
Факториал.
Для целого числа k(0≤k≤12) посчитать k!.
Работа выполнена 16.12.18 студентом группы П2-16 Вологузовым В.В.
*/
#include <stdio.h>
int main() {
    int n;
    scanf("%d", &n);
    int fac = 1;
    while (n)
        fac *= n--;
    printf("%d", fac);
  return 0;
}
