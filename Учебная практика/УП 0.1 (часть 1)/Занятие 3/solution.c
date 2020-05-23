#include <stddef.h>
#include <stdio.h>
#include <string.h>


int stringStat(const char *string, int multiplier, int *count)
{ 
          *count = *count+1;
          return strlen(string)*multiplier;
}


    
