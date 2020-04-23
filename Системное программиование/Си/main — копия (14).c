#include <stdio.h>

int main() {
    int m,n,i,j,sum=0,max,min, max_st = 0,min_st = 0,k = 0;
    scanf("%d %d",&n,&m);
    int a[100][100];
    for (i=0; i<n; i++)
        for (j=0; j<m; j++)
            scanf("%d",&a[i][j]);

    for (i=0; i<n; i++)
        sum += a[i][0];
    max = min = sum;

    sum = 0;
    for (j=0; j<m; j++)
    {
        for (i=0; i<n; i++)
            sum+=a[i][j];
        if (sum > max) {
            max = sum;
            max_st = j;
        }
        if (sum < min) {
            min = sum;
            min_st = j;
        }
        sum = 0;
    }

    for (i = 0; i < n; i++) {
        k = a[i][max_st];
        a[i][max_st] = a[i][min_st];
        a[i][min_st] = k;
    }

    for (i=0; i<n; i++) {
        for (j=0; j<m; j++)
            printf("%d ",a[i][j]);
        printf("\n");
    }
}
