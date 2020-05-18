//�������� ������������ ����������
//� ���� ������� ��� ���������� ������� ����������� ������������ ���������� libsolution.so � ������� ����������� ������� �� ��������� ����������:
//int stringStat(const char *string, size_t multiplier, int *count);
//������� ���������� �������� ����� ������ string, ���������� �� multiplier, � ����������� �� 1 ��������, �� ������� ��������� count.
//������������� �������
//������� ��������������� � ���� ���� ������ solution.c � Makefile, � ��������� �������������� ���� �� ���������, ������� �������� � ������ ����� ����������.
//�����
#include <stddef.h>
#include "solution.h"
int stringStat(const char *string, size_t multiplier, int *count) {
    int i = 0;
    while (string[i] != '\0') {
        i++;
    }
    i = i * multiplier;
    (*count)++;
    return i;
}
