import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Main {

    /**
     * Dizi elemanlarından tekrar eden çift sayıları bulan program
     *
     *
     */

    static Integer[] bul(int[] arr){

        List<Integer> sonuc=new ArrayList<Integer>();


        for(int i=0;i<arr.length;i++){

            for (int j=i+1;j< arr.length-1;j++){

                if(arr[i]==arr[j] && arr[i]%2==0){
                    sonuc.add(arr[i]);
                    break;
                 }
            }
        }


        Integer[] sonucArray=new Integer[sonuc.size()];
        sonucArray=sonuc.toArray(sonucArray);
        /*
        for (int i=0;i<sonucArray.length;i++){
            System.out.println(sonucArray[i]);
        }

        */
        return sonucArray;

    }

    public static void main(String[] args) {
        int[] sayilar={2,4,8,4,6,2,8,5,7,7,10,2};
        System.out.println(bul(sayilar));
    }
}