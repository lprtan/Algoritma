public class Main {
    public static int[] BubleSort(int arr[]){
        int[] sortedArr = arr.clone();

        for (int i=0;i<sortedArr.length;i++){
            for (int j=i+1;j<sortedArr.length;j++){
                if (sortedArr[i]>sortedArr[j]){
                    int temp=sortedArr[j];
                    sortedArr[j]=sortedArr[i];
                    sortedArr[i]=temp;
                }
            }
        }
        return sortedArr;

    }

    public static void main(String[] args) {
        int[] arr={2,4,3,1,5};
        int[] SortArr = new int[arr.length];
        SortArr = BubleSort(arr);

        System.out.println("Sıralanmamış Dizi: ");

        for (int item:arr) {
            System.out.print(item+" ");
        }
        System.out.println();

        System.out.println("Sıralanmış Dizi: ");

        for (int item:SortArr) {
            System.out.print(item+" ");
        }

    }
}