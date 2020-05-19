#include <list>
#include <string>
#include <fstream>
#include <iostream>
#include <Windows.h>

using namespace std;
const string G_PATH = "data.txt";

// Основная структура данных.
struct Data
{
    // Конструкторы.
    Data();
    Data(string mark, string color, short  mumber);
    // Загрузка в файла.
    void loadFromFile();
    // Перегрузка оператора < используется в функции sort.
    bool operator<(const Data& data);
    // Данные.
    string mMark, mColor;
    short  mNumber;
};

// Конструктор по умолчанию.
Data::Data()
{
    mMark   = ""; mColor  = "";  mNumber = 0;
}

// Конструктор с параметрами.
Data::Data(string mark, string color, short number)
{
    mMark   = mark; mColor  = color; mNumber = number;
}

void Data::loadFromFile()
{
    // Создаём файловый поток ввода и открываем файл ::G_PATH = "data.db".
    ofstream fout;
    fout.open(::G_PATH, ios_base::app);
    // Загрузка данных в поток.
    fout << mMark << " " << mColor << " " << mNumber << endl;
    fout.close();
}

bool Data::operator<(const Data& data)
{
    return mNumber < data.mNumber;
}

// Перегрузка оператора потокового вывода, используется для 
// вывода данных в консоль.
ostream& operator<< (ostream& s, const Data& data)
{
    return s
        << "Марка: " << data.mMark   << endl
        << "Цвет: "  << data.mColor  << endl
        << "Номер: " << data.mNumber << endl;
}

// Загрузка данных из файла.
void unload(list<Data>& list)
{
    // Создаём файловый поток вывода и открываем файл ::G_PATH = "data.db".
    // При остутсвии файла, создаётся новый.
    ifstream fout;
    fout.open(::G_PATH);
    // Временные переменные, нужные для заполнения списка данных.
    string   mark, name, color;
    short    number;
    // Циклическое заполнение списка.
    while (fout >> mark >> color >> number)
        list.push_back(Data(mark, color, number));
    fout.close();
}


int main() 
{
    // Включение русского языка на воод и вывод.
    SetConsoleCP(1251u);
    SetConsoleOutputCP(1251u);
    // Создание и заполнение списка.
    list<Data> dataList;
    unload(dataList);
    // Дополнительные переменные.
    int choose;
    Data data;
    // Цикл меню.
    do {
        cout                            << endl;
        cout << "1.Добавить данные."    << endl;
        cout << "2.Вывести данные."     << endl;
        cout << "3.Сортировать данные." << endl;
        cout << "9.Выход."              << endl << "-> ";
        cin >> choose;
        //Обработка введёной информации.
        switch (choose) 
        {
        case 1: // Добавление данных.
            cout << "Введите Марку:" << endl;
            cin >> data.mMark;
            cout << "Введите Цвет:" << endl;
            cin >> data.mColor;
            cout << "Введите номер:" << endl;
            cin >> data.mNumber;
            dataList.push_back(data);
            break;
        case 2: // Вывод данных.
            if (dataList.empty())
                cout << "Список пуст." << endl;
            else
                for (const auto& e : dataList)
                    cout << e << endl;
            break;
        case 3: // Сортировка данных.
            dataList.sort();
            break;
        default: // Обработка неккоректного ввода.
            cout << "Нет такого пункта меню." << endl;
            break;
        }
    // Пока пользователь на ввведёт 9, продолжать работать.
    } while (choose != 9);
    // Перед выходом происходит сохранение данных.
    for (auto& e : dataList)
        e.loadFromFile();
    return 0;
}