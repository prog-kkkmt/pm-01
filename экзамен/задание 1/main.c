#include <stdio.h>
#include <stdlib.h>
#include "queue.h"

int main(void){
    node_t * list;

    if ( ( list = create_list() ) == NULL ){
        fprintf(stderr, "Can't create list No items entered!\n");
        exit(EXIT_FAILURE);
    }
    printf("You have entered:\n");
    print_list(list);

    printf("Without negative elements:\n");
    if ( ( list = remove_if(list, is_negative) ) == NULL ){
        printf("No elements in list!\n");
    }
    else {
        print_list(list);
        clear_list(list);
    }

    system("pause");
    exit(EXIT_SUCCESS);
}
