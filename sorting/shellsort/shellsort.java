package shellsort;
public class shellsort{
    public static void printArray(int[] arr){
        int n = arr.length;
        for(int i=0; i<n; i++){
            System.out.println(arr[i]);
        }
    }
    private int shellsort_algo(int[] arr){
        int n=arr.length;
        for(int interval=n/2; interval>0; interval/=2){
            for(int i=interval; i<n; i++){
                int temp=arr[i];
                int j;
                for(j=i; j>=interval && arr[j-interval]>temp; j-=interval){
                    arr[j] = arr[j-interval];
                }
                arr[j]=temp;
            }
        }
        return 0;
    }
    public static void main(String[] args){
        int[] arr = {12, 34, 54, 2, 3};
        System.out.println("Before being sorted by Shell Sort: ");
        printArray(arr);
        System.out.println("After being sorted: ");
        shellsort sort = new shellsort();
        sort.shellsort_algo(arr);
        printArray(arr);
    }
}