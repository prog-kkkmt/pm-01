/**
Для целого числа K (от 1 до 99 включительно) напечатать фразу «Мне K лет»,
учитывая при этом, что при некоторых значениях K слово «лет» надо заменить
на слово «год» или «года». Например, 11 лет, 22 года, 51 год.
Работа выполнена 16.12.18 студентом группы П2-16 Вологузовым В.В.
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
        printf("Мне %d лет\n", b);
        break;
    default:
        switch (a) {
        case 1:
            printf("Мне %d год\n", b);
            break;
        case 2:
        case 3:
        case 4:
            printf("Мне %d года\n", b);
            break;
        default:
            printf("Мне %d лет\n", b);
            break;
        }
    }
    return 0;
}
