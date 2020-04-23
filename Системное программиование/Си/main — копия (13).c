#include <stdio.h>
int main() {
    int a[100][100], i, j, n, k, temp, l;

    scanf("%d", &n);
    for (i = 0; i < n; i++)
        for (j = 0; j < n; j++)
            scanf("%d", &a[i][j]);
    scanf("%d", &k);

    for (i = 0; i < n; i++) {
        for (j = 0; j < k; j++) {
            temp = a[i][n - 1];
            for (l = n - 1; l > 0; l--) {
                a[i][l] = a[i][l - 1];
            }
            a[i][0] = temp;
        }
    }

    for (i = 0; i < n; i++) {
        for (j = 0; j < n; j++)
            printf("%d ", a[i][j]);
        printf("\n");
    }
}
