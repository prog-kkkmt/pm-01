//Создание динамической библиотеки
//В этом задании Вам необходимо создать разделяемую динамическую библиотеку libsolution.so в которой реализовать функцию со следующим прототипом:
//int stringStat(const char *string, size_t multiplier, int *count);
//Функция возвращает значение длины строки string, умноженное на multiplier, и увеличивает на 1 значение, на которое указывает count.
//Представление решения
//Решение предоставляется в виде двух файлов solution.c и Makefile, в последнем предполагается цель по умолчанию, которая приводит к сборке Вашей библиотеки.
//Вывод
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
