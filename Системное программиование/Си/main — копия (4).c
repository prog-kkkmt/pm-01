int s;
    if(*p_a < *p_b)
        s = *p_a;
    else
        s = *p_b;
    if (s < *p_c)
        *p_c = s;
    else
        s = *p_c;
    s = *p_a = *p_b = *p_c;
