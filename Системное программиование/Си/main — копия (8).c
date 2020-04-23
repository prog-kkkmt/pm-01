#include <stdio.h>
#include <string.h>
int main() {
  char str1[100],str2[100];
  gets(str1);
  gets(str2);
  if ((str1[strlen(str1)-1] == str2[0]+32)||(str1[0] == str2[strlen(str2)-1]-32))
    printf("yes");
  else
    printf("no");
}
