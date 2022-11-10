import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

public class Main {

    public static int beautifulDays(int i, int j, int k) {

        int count=0;
        for(int x=i;x<=j;x++){

            String sayi=String.valueOf(x);
            StringBuilder sb=new StringBuilder(sayi);
            String tersSayi=sb.reverse().toString();

            double sonuc=Math.abs(x-Integer.parseInt(tersSayi));
            sonuc=sonuc/k;

            if(Math.floor(sonuc) == sonuc){
                count++;
             }
        }

        return  count;
    }

    public static void main(String[] args) {

        System.out.println(beautifulDays(949488 ,1753821 ,5005440));
    }
}