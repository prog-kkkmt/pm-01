/**
Дано целое число 1≤n≤40, необходимо вычислить n-е число Фибоначчи.
Работа выполнена 11.12.18 студентом группы П2-16 Дуругяном А.В.
*/
#include <iostream>
#include <cmath>
using namespace std;
int main(){
    int a, b, d, i;
    cin >> a >> b;
    while (a > 0 && b > 0){
            d = a % b;
            a = b;
            b = d;
    }
    cout << a;
}
