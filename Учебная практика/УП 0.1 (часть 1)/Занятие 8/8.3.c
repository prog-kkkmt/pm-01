/**
С клавиатуры вводятся a и k. Возвести число a в степень k.
Работа выполнена 16.12.18 студентом группы П2-16 Вологузовым В.В.
*/
#include <stdio.h>
int main() {
  int a = 0, k = 0;
  int res = 1;
  scanf("%d %d", &a, &k);
  while(k > 0){
    if (k % 2 == 1){
    res = res * a;
    }
    a = a * a;
    k = k / 2;
 }
  printf("%d\n", res);
}
