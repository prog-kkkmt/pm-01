   // �������� ������� binary_to_decimal(bin_n) � decimal_to_binary(n)
    //��� �������� ����� ��������������� ����� �� �������� �������
   // ��������� � ���������� � ��������. ������� binary_to_decimal(bin_n)
   // ��������� �� ���� ������, �������������� ����� �������� ������ ����� (
 //��������, "101101"), � ���������� ����� ����� � �������� � ����������
 //������� ���������. ������� decimal_to_binary(n) ��������� �� ���� �����
 //����� n � ���������� ������, �������������� �������� ������ ����� n.
 //����� ������� ������ ������ �� �����.
def binary_to_decimal(bin_n):
    return int(bin_n,2)
    # ��������� ������ (�������� �. �.), ���������� ����� (���������� �. �.)
    # ��� ���
def decimal_to_binary(n):
    return bin(n)[2:]
    # ��������� ����� (���������� �. �.), ���������� ������ (�������� �. �.)
    # ��� ���
