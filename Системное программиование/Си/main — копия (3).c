int minmax(int arr[], int n, int fl){
    int min = arr[0],max = arr[0];
    for (int i = 1; i < n;i++){
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    return fl == 0 ? min : max;
}
