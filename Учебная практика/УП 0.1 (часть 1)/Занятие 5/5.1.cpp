/**
�������� ������� power, ����������� ���������� ������ ����� �
��������������� ����� �������.
������ ��������� 14.12.18 ��������� ������ �2-16 ������� �.�.
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
