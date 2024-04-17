#include <iostream>
using namespace std;
int shellSort(int arr[], int n){
    for(int interval=n/2; interval>0; interval /=2){
        for(int i=interval; i<n; i+=1){
            int temp = arr[i];
            int j;
            for(j=i; j>=interval && arr[j-interval]>temp; j -=interval){
                arr[j]  =arr[j-interval];
            }
            arr[j]=temp;
        }
    }
    return 0;
}
void printArray(int arr[], int n){
    for(int i=0; i<n; i++){
        cout<<arr[i]<<" ";
    }
}
int main(){
    int arr[] = {12, 34, 54, 2, 3};
    int n = sizeof(arr)/sizeof(arr[0]);
    // cout<<'Array before sorting: \n';
    printArray(arr, n);
    shellSort(arr, n);
    // cout<<'\nArray after sorting:';
    cout<<endl;
    printArray(arr, n);
    return 0;
}