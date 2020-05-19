Выведите таблицу размером n \times nn×n, заполненную числами от 11 до n^2n2
по спирали, выходящей из левого верхнего угла и закрученной по часовой стрелке, как показано в примере (здесь n=5n=5):
n=int(input())
tab=[[0] *n for x in range(n) ]
tab[n//2][n//2]=n**2
dx,dy = 1,0
x,y = 0,0
myarray = [[0]* n for j in range(n)]
for i in range(1,n**2+1):
    myarray[x][y] = i
    nx,ny = x+dx, y+dy
    if 0<=nx<n and 0<=ny<n and myarray[nx][ny] == 0:
        x,y = nx,ny
    else:
        dx,dy = -dy,dx
        x,y = x+dx, y+dy
for x in range(n):
    for y in range(n):
        print(myarray[y][x],end=' ')
    print()