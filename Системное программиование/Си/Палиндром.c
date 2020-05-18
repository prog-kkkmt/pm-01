    //Определите, является ли введенная строка палиндромом. Выведите YES, если это так, иначе NO.
text= input()
if text.replace(' ','').lower()==text.replace(' ','').lower()[::-1]:
    print('YES')
else:
    print('NO')
