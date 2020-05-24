#include <iostream>
using namespace std;

long double fact(int N)
{
if(N < 0)
return 0;
if (N == 0)
return 1;
else
return N * fact(N - 1);
}

int main()
{
int N;
cin >> N;
cout << "Факториал " << N << " = " << fact(N) << endl;
return 0;
}
