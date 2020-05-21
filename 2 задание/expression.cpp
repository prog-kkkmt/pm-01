#include <iostream>
using namespace std;

long fact(int n)
{
    long f = 1;
    for (int i = 2; i <= n; ++i)
        f *= i;
    return f;
}

int main()
{
    int n;
    cin >> n;
    double s = 0.0;
    for (int i = 1; i <= n; ++i)
        s += 1.0/fact(i);
    cout << s;
    return 0;
}
