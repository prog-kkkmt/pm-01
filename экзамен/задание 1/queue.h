#ifndef QUEUE_H_INCLUDED
#define QUEUE_H_INCLUDED

typedef struct NODE {
    int val;
    struct NODE * prev;
    struct NODE * next;
} node_t;

/* создание элемента очереди */
node_t * new_node(int val){
    node_t * n;
    if ( ( n = (node_t*)malloc(sizeof(node_t)) ) == NULL )
        return NULL;
    n->val = val;
    n->prev = NULL;
    n->next = NULL;
    return n;
}

/* удал€ет элемент, возвращает указатель на следующий */
node_t * del_node (node_t * n){
    node_t * ret = n->next;
    if ( n->prev )
        n->prev->next = n->next;
    if ( n->next )
        n->next->prev = n->prev;
    free(n);
    return ret;
}

/* очищает список */
void clear_list(node_t * n){
    while ( n = del_node(n) )
        ;
}

/* удал€ет элементы, соответствующие условию, возвращает указатель на первый элемент обработанного списка */
node_t * remove_if(node_t * n, int (*test_func)(const node_t * nodeToTest)){
    node_t * first = n;
    while ( first && test_func(first) )
        first = del_node(first);
    if ( ! first )
        return NULL;
    for ( n = first->next; n != NULL; ){
        if ( test_func(n) )
            n = del_node(n);
        else
            n = n->next;
    }
    return first;
}
/* возращает элемент при его отрицательности */
int is_negative(const node_t * n){
    return ( n->val < 0 );
}

/* создаЄт список */
node_t * create_list(void){
    node_t * first, * last, * current;
    static char buf[32] = { 0 };

    first = last = NULL;

    printf("Enter some numbers (empty string - finish):\n");
    while ( fgets(buf, 32, stdin) ) {
        if ( *buf == '\n' )
            break;
        if ( ( current = new_node(atoi(buf)) ) == NULL ){
            if ( first )
                clear_list(first);
            return NULL;
        }
        if ( ! first ){
            first = current;
            last = first;
        }
        else {
            current->prev = last;
            last->next = current;
            last = current;
        }
    }
    return first;
}

/* ¬ыводит список */
void print_list(const node_t * n){
    while ( n ){
        printf("%d\n", n->val);
        n = n->next;
    }
}

#endif // QUEUE_H_INCLUDED
