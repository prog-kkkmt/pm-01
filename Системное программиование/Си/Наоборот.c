//Модифицируйте любой из алгоритмов сортировки так, чтобы отсортировать список чисел в обратном порядке.
def bubbleSort(tab):
    n = len(tab)
    for i in range(n):
        for j in range(0, n-i-1):
            if tab[j] < tab[j+1] :
                tab[j], tab[j+1] = tab[j+1], tab[j]
    return tab
arr = map(int,input().split())
print(*bubbleSort(list(arr)))

