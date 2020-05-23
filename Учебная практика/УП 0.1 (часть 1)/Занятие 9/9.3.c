/**
Для заданной матрицы вывести на экран транспонированную матрицу.
Работа выполнена 14.12.18 студентом группы П2-16 Дуругян А.В.
*/
#include <stdio.h>
int main() {
  int n, m;
    scanf("%d %d", &n, &m);
    int a[n][m];
    for(int i = 0; i < n; i++)
        for(int j = 0; j < m; j++)
            scanf("%d", &a[i][j]);

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            printf("%d ", a[j][i]);
        printf("\n");
    }
  return 0;
}
