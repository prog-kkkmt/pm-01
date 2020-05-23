/**
Напишите программу, которая суммирует целые числа.
Работа выполнена 14.12.18 студентом группы П2-16 Дуругян А.В.
*/
#include <iostream>
using namespace std;
int main(){
    int a[100], b[100], t;
    cin >> t;
    for (int i = 0; i < t; i++){
        cin >> a[i] >> b[i];
    }
    for (int i = 0; i < t; i++)
        cout << a[i] + b[i] << endl;
}
