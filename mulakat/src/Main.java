import java.util.Arrays;

public class Main {
    public static int  kar(int[] arr){
        int adet=0;
        int[] array1=new int[(arr.length/2)+1];
        int[] array2=new int[(arr.length/2)-1];
        System.arraycopy(arr, (arr.length/2)-1, array1, 0, (arr.length/2)+1);
        System.arraycopy(arr, 0, array2, 0, (arr.length/2)-1);
        Arrays.sort(array2);
        Arrays.sort(array1);
        int enBuyukFark =array2[array2.length-1]-array2[0];

            for(int i=0;i<array1.length;i++){
                if(enBuyukFark%array1[i]==0){
                       adet= enBuyukFark /array1[i];
                       break;
                }
            }

       return adet*array1[array1.length-1];

    }
    public static void main(String[] args) {
        int[] array1={20, 30, 40, 10, 5, 80, 100, 60};
        int[] array2={100, 50, 200, 400, 20, 60, 10, 90, 300, 200};
        System.out.println(kar(array1));
        System.out.println(kar(array2));
    }
}