#include <stdio.h>

int main() {
    int i,n,a[100],max = -9999,min = 9999,t;
    scanf("%d",&n);
    for (i = 0; i < n; i++) {
        scanf("%d",&a[i]);
        if (a[i] > max)
            max = a[i];
        if (a[i] < min)
            min = a[i];
    }
    for (i = 0; i < n; i++) {
        if (a[i] == min)
            a[i] = max;
        else if (a[i] == max)
            a[i] = min;
    }
    for (i = 0; i < n; i++)
        printf("%d ",a[i]);
}
