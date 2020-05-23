/**
Напишите программу для решения квадратных уравнений вида ax2+bx+c=0 (относительно x).
На вход программа получает три целых числа: a , b и c, соответственно.
При этом гарантируется, что a≠0. На вывод программа должна вывести
два вещественных корня уравнения, разделённые пробелом.
Если вещественных корней нет, то программа должна вывести
строку "No real roots". Если у уравнения имеется только один корень (кратный корень),
то программа должна вывести его дважды.
Работа выполнена 14.12.18 студентом группы П2-16 Дуругян А.В.
*/
#include <iostream>
#include <cmath>
using namespace std;
int main()
{
    int a, b, c;
    cin >> a >> b >> c;
    int d = (b*b) - (4 * a * c);
    if (d > 0){
        cout << ((b*(-1)) + sqrt(d)) / (2*a) <<' ';
        cout << ((b*(-1)) - sqrt(d)) / (2*a);
    }
    else if (d == 0){
        cout << (b*(-1)) / (2*a) <<' ';
        cout << (b*(-1)) / (2*a);
    }
    else
        cout << "No real roots";
    return 0;
}
