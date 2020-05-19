#include <list>
#include <string>
#include <fstream>
#include <iostream>
#include <Windows.h>

using namespace std;
const string G_PATH = "data.txt";

// �������� ��������� ������.
struct Data
{
    // ������������.
    Data();
    Data(string mark, string color, short  mumber);
    // �������� � �����.
    void loadFromFile();
    // ���������� ��������� < ������������ � ������� sort.
    bool operator<(const Data& data);
    // ������.
    string mMark, mColor;
    short  mNumber;
};

// ����������� �� ���������.
Data::Data()
{
    mMark   = ""; mColor  = "";  mNumber = 0;
}

// ����������� � �����������.
Data::Data(string mark, string color, short number)
{
    mMark   = mark; mColor  = color; mNumber = number;
}

void Data::loadFromFile()
{
    // ������ �������� ����� ����� � ��������� ���� ::G_PATH = "data.db".
    ofstream fout;
    fout.open(::G_PATH, ios_base::app);
    // �������� ������ � �����.
    fout << mMark << " " << mColor << " " << mNumber << endl;
    fout.close();
}

bool Data::operator<(const Data& data)
{
    return mNumber < data.mNumber;
}

// ���������� ��������� ���������� ������, ������������ ��� 
// ������ ������ � �������.
ostream& operator<< (ostream& s, const Data& data)
{
    return s
        << "�����: " << data.mMark   << endl
        << "����: "  << data.mColor  << endl
        << "�����: " << data.mNumber << endl;
}

// �������� ������ �� �����.
void unload(list<Data>& list)
{
    // ������ �������� ����� ������ � ��������� ���� ::G_PATH = "data.db".
    // ��� ��������� �����, �������� �����.
    ifstream fout;
    fout.open(::G_PATH);
    // ��������� ����������, ������ ��� ���������� ������ ������.
    string   mark, name, color;
    short    number;
    // ����������� ���������� ������.
    while (fout >> mark >> color >> number)
        list.push_back(Data(mark, color, number));
    fout.close();
}


int main() 
{
    // ��������� �������� ����� �� ���� � �����.
    SetConsoleCP(1251u);
    SetConsoleOutputCP(1251u);
    // �������� � ���������� ������.
    list<Data> dataList;
    unload(dataList);
    // �������������� ����������.
    int choose;
    Data data;
    // ���� ����.
    do {
        cout                            << endl;
        cout << "1.�������� ������."    << endl;
        cout << "2.������� ������."     << endl;
        cout << "3.����������� ������." << endl;
        cout << "9.�����."              << endl << "-> ";
        cin >> choose;
        //��������� ������� ����������.
        switch (choose) 
        {
        case 1: // ���������� ������.
            cout << "������� �����:" << endl;
            cin >> data.mMark;
            cout << "������� ����:" << endl;
            cin >> data.mColor;
            cout << "������� �����:" << endl;
            cin >> data.mNumber;
            dataList.push_back(data);
            break;
        case 2: // ����� ������.
            if (dataList.empty())
                cout << "������ ����." << endl;
            else
                for (const auto& e : dataList)
                    cout << e << endl;
            break;
        case 3: // ���������� ������.
            dataList.sort();
            break;
        default: // ��������� ������������� �����.
            cout << "��� ������ ������ ����." << endl;
            break;
        }
    // ���� ������������ �� ������ 9, ���������� ��������.
    } while (choose != 9);
    // ����� ������� ���������� ���������� ������.
    for (auto& e : dataList)
        e.loadFromFile();
    return 0;
}