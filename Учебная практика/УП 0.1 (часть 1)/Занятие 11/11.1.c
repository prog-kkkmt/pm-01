/**
��� �������� ������� ������� �� ����� ����������������� �������.
������ ��������� 21.12.18 ��������� ������ �2-16 ��������� �.�.
*/
#include <stdio.h>
int main() {
  int n, m;
    scanf("%d %d", &n, &m);
    int a[n][m];
    for(int i = 0; i < n; i++)
        for(int j = 0; j < m; j++)
            scanf("%d", &a[i][j]);
    printf("\n");
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            printf("%d ", a[j][i]);
        printf("\n");
    }
  return 0;
}
