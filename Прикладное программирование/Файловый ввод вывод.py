#Напишите программу, которая считывает из файла строку, соответствующую тексту, сжатому с помощью кодирования повторов, и производит обратную операцию, получая исходный текст.
inf = open('C:\\Users\\user\\Downloads\\dataset_3363_2.txt', 'r')
s1 = inf.readline()
i = 0
d = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'}
g = ''
l = 0
s = ''
while i < len(s1):
    if s1[i] not in d:
        s = s1[i]
    elif s1[i] in d:
        g += s1[i]
    if s1[i+1] in d:
        i += 1
        continue
    else:
        while l < int(g):
            print(s,end='')
            l += 1
            l = 0
            g = ''

            i+=1

inf.close()