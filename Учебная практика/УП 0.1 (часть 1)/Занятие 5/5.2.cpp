/**
�������� ���������, ������� ��������� ����� �����.
������ ��������� 14.12.18 ��������� ������ �2-16 ������� �.�.
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
