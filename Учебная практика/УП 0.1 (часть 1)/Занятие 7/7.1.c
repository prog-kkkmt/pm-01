/**
��� ������ ����� K (�� 1 �� 99 ������������) ���������� ����� ���� K ���,
�������� ��� ����, ��� ��� ��������� ��������� K ����� ���� ���� ��������
�� ����� ���� ��� �����. ��������, 11 ���, 22 ����, 51 ���.
������ ��������� 16.12.18 ��������� ������ �2-16 ����������� �.�.
*/
#include <stdio.h>
#include <locale.h>
#include <windows.h>
int main()
{
    setlocale(LC_ALL, "Russian");
    int b, a;
    scanf("%d", &b);
    a = b % 10;
    switch (b) {
    case 11:
    case 12:
    case 13:
    case 14:
        printf("��� %d ���\n", b);
        break;
    default:
        switch (a) {
        case 1:
            printf("��� %d ���\n", b);
            break;
        case 2:
        case 3:
        case 4:
            printf("��� %d ����\n", b);
            break;
        default:
            printf("��� %d ���\n", b);
            break;
        }
    }
    return 0;
}
