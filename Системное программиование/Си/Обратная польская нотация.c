 //�������� �������� (��� �����������) ������ � ��� �������������� ������ ��������������� ���������.
 //� ����� ������ ����, ������� ����� ��������� � ���������, ������������ ����� ���, � �� ����� ����.
 //���, ��������� a + b ������������ � a b +, � ��������� a + (b - c) * d � � a b c - d * +.
 //�������� ���������, ������� ��������� �������� ���������, ����������� � ����������� ����.
 //������������ ������ ����� +, -, *, /.
#include <stdio.h>
class Stack:
    def __init__(self):
        self.stack=[]
    def push(self,p):
        self.stack.append(p)
    def pop(self):
        return self.stack.pop()
    def empty(self):
        return len(self.stack)==0
st = Stack()
res = 0
lst = list(map(str,input().split()))
for i in lst:
    if i.isdigit():
        st.push(int(i))
    else:
        y = st.pop()
        x = st.pop()
        z = {
            '+': lambda x,y: x + y,
            '-': lambda x,y: x - y,
            '*': lambda x,y: x * y,
            '/': lambda x,y: x // y
        }[i](x, y)
        st.push(z)
        #print(z)
print(st.pop())
