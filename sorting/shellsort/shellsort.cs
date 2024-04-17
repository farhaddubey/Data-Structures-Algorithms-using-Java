using System;
class ShellSort {
    static void shell(int[] arr){
        int n= arr.length;
        for(int i=0; i<n; i++){
            Console.Write(arr[i]+" ");
        }

    }
    int sort(int[] arr){
        int n =arr.length;
        // To start with interval of n/2 and then reducing 
        for(int interval=n/2; interval>0; interval/=2 ){ 
            // The 1st interval elements are already in interval order, motto is to add 1 by 1 all elements in the 1st interval array 
            for(int i=interval; i<n; i++){
                int temp = arr[i];
                int j;
                for(j=i; j>=interval && arr[j-interval]>temp; j-= interval){
                    arr[j] = arr[j-interval];
                }
                arr[j] = temp;
            }
        }
        return 0;
    }
    public static void main(){
        int[] arr={12, 34, 54, 2, 3};
        Console.Write("Array before sorting: \n");
        printArray(arr);

        ShellSort ob = new ShellSort();
        ob.sort(arr);

        Console.Write("Array after sorting: \n");
        printArray(arr);
    }
}