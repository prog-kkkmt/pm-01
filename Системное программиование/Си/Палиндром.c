    //����������, �������� �� ��������� ������ �����������. �������� YES, ���� ��� ���, ����� NO.
text= input()
if text.replace(' ','').lower()==text.replace(' ','').lower()[::-1]:
    print('YES')
else:
    print('NO')
