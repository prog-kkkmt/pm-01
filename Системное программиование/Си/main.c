#include <stdio.h>

int main() {
    int i,n,a[100],k;
    scanf("%d",&n);
    k = n/2+1;
    for (i = 1; i <= n; i++) {
        scanf("%d",&a[i]);
        if ((i == k)||(i > k))
            printf("%d ",a[i]);
    }
    for (i = 1; i <= n; i++) {
        if (i < k)
            printf("%d ",a[i]);
    }
}
