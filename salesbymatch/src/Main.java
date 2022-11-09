
import java.util.*;

public class Main {

    // https://www.hackerrank.com/challenges/sock-merchant/problem
    public static int sockMerchant(int n, List<Integer> ar) {
        int count=1;
        int ciftSayisi=0;
        int temp=-1;

        Collections.sort(ar);

        for(int i=0;i<n;i++){

            for(int j=i+1;j<n;j++){

                if(ar.get(i)!=temp){
                    if(ar.get(i)==ar.get(j)){
                        count++;
                    }
                }

            }
            ciftSayisi+=(count/2);
            count=1;
            temp= ar.get(i);

        }

        return ciftSayisi;
    }
    public static void main(String[] args) {
        List<Integer> ar=new ArrayList<Integer>();
        ar.add(4);
        ar.add(5);
        ar.add(5);
        ar.add(5);
        ar.add(6);
        ar.add(6);
        ar.add(4);
        ar.add(1);
        ar.add(4);
        ar.add(4);
        ar.add(3);
        ar.add(6);
        ar.add(6);
        ar.add(3);
        ar.add(6);
        ar.add(1);
        ar.add(4);
        ar.add(5);
        ar.add(5);
        ar.add(5);
        List<Integer> arr=new ArrayList<Integer>();
        arr.add(5);
        arr.add(5);
        arr.add(5);
        arr.add(5);
        arr.add(5);
        arr.add(5);
         System.out.println(sockMerchant(20,ar));
       //System.out.println(sockMerchant(6,arr));
    }
}