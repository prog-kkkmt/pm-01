var
  a: array[1..999] of integer;
  n, i: integer;
  s: integer;

begin
  write('n= ');
  readln(n);
  s := 0;
  for i := 1 to n do
  begin
    read(a[i]);
    s := s + a[i];
  end;
  writeln('s= ', s);
end.