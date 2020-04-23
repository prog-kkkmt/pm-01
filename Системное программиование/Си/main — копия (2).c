void sort_arr(int arr[], int n,int fl){
    int min = arr[0],temp = 0,temp_num = 0,k = n-1,key = 0;
    for (int i = 0;i < n;i++){
        min = arr[i];
        for (int j = i+1;j < n;j++){
            if (arr[j] < min){
                min = arr[j];
                temp_num = j;
                key = 1;
            }
        }
        if (key == 1){
        temp = arr[temp_num];
        arr[temp_num] = arr[i];
        arr[i] = temp;
        }
    key = 0;
    }
    if (fl == 1){
        for (int i = 0;i < n/2 + n%2;i++){
            temp = arr[i];
            arr[i] = arr[k];
            arr[k] = temp;
            --k;
        }
    }

}
