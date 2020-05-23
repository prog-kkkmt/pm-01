/**
Напишите функцию power, реализующую возведение целого числа в
неотрицательную целую степень.
Работа выполнена 14.12.18 студентом группы П2-16 Дуругян А.В.
*/
#include <iostream>
using namespace std;
int power(int x, int p);
int main(){
    int x, p;
    cin >> x >> p;
    cout << power(x,p);
}
int power(int x, int p) {
    int answer;
    answer = x;
    for (int i = 1; i < p; i++)
        answer *= x;
    if (p == 0)
        return 1;
    return answer;
}
