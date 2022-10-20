import java.util.Scanner;

public class Main {

    static int f(int a){

        if(a==1){
            return 1;
        }
       return f(a-1)+a;

    }
    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        System.out.println("Bir sayı giriniz lütfen");
        int a=input.nextInt();

        System.out.println(f(a));
    }
}