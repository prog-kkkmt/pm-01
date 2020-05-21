var
  a, n, s: integer;

begin
  s := 0;
  readln(n);
  
  readln(a);
  while (n > 0) do
  begin
    s := s + a;
    dec(n);
    readln(a);
  end;
  
  writeln(s);
end.