
function printArray(arr){
    let n = arr.length;
    for(let i=0; i<n; i++){
        console.log(arr[i]+" ");
    }
}
function sort(arr){
    let n =arr.length;
    for( let interval=Math.floor(n/2); interval>0; interval=Math.floor(interval/2)){
        for(let i=interval; i<n; i++){
            let temp=arr[i];
            let j;
            for(j=i; j>=interval && arr[j-interval]>temp; j-=interval){
                arr[j]=arr[j-interval];
            }
            arr[j] = temp;
        }
    }
    return arr;
}


let arr = [12, 34, 54, 2, 3];
console.log("Array before sorting");
printArray(arr);

arr=sort(arr);
console.log("Array after sorting")
printArray(arr);