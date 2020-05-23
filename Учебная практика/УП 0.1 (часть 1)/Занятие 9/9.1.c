/**
Напишите программу, выводящую на экран все элементы массива,
которые меньше последнего элемента и больше первого элемента массива.
Работа выполнена 16.12.18 студентом группы П2-16 Вологузовым В.В.
*/
#include <stdio.h>
int main() {
    int n, i;
    int worked = 0;
    scanf("%d", &n);
    int a[n];
    for(i = 0; i < n; i++)
        scanf("%d", &a[i]);
    for(i = 0; i < n; i++)
        if(a[i] < a[n - 1] && a[i] > a[0])
        {
            printf("%d ", a[i]);
            worked = 1;
        }
    if(worked == 0) printf("%d", worked);
  return 0;
}
