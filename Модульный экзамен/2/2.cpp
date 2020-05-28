/*Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара совпадающих».
По памяти

#include <iostream>
int main()
{
    int a,b,c;
    std::cin>>a>>b>>c;
    bool e=0;
    if ((a==b)||(a==c)||(b==c))
        e=1;
    std::cout<<e;
    return 0;
}
*/
#include <iostrem>
int main(){
int a, b, c;
std:: cin >> a >> b >> c;
std:: cout <<(a==b || a==c ||b==c);
return 0;
}
