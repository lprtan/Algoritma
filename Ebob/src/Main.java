public class Main {

    // 3 farklı algoritmada kod çalışma süresi testi
    public static int ebobFunc(int a,int b){//büyük olan sayıya göre işlem yapan fonksiyon
        int max= a;
        int ebob=1;
        if (b>a){
            max=b;
        }

        for (int i=max;i>0;i--){
            if (a%i==0 && b%i==0){
                ebob=i;
                break;
            }
        }
        return ebob;
    }

    public static int ebobFunc2(int a,int b){ //küçük olan sayıya göre işlem yapan fonksiyon
        int min= a;
        int ebob=1;
        if (b<a){
            min=b;
        }

        for (int i=min;i>0;i--){
            if (a%i==0 && b%i==0){
                ebob=i;
                break;
            }
        }
        return ebob;
    }

    public static int ebobFunc3(int a,int b){

        while (b!=0){
            int mod=a%b;
            a=b;
            b=mod;
        }

        return a;
    }

    public static void main(String[] args) {
        long startTime = System.currentTimeMillis(); // Başlangıç zamanını al
        System.out.println(ebobFunc(800000000,800000001));
        long endTime = System.currentTimeMillis(); // Bitiş zamanını al
        long elapsedTime = endTime - startTime; // Toplam süreyi hesapla
        System.out.println("Kodun çalışma süresi: " + elapsedTime + " milisaniye");

        System.out.println("------------------------------------------------------------");

        long startTime2 = System.currentTimeMillis(); // Başlangıç zamanını al
        System.out.println(ebobFunc2(800000000,800000001));
        long endTime2 = System.currentTimeMillis(); // Bitiş zamanını al
        long elapsedTime2 = endTime2 - startTime2; // Toplam süreyi hesapla
        System.out.println("Kodun çalışma süresi: " + elapsedTime2 + " milisaniye");

        System.out.println("------------------------------------------------------------");

        long startTime3 = System.currentTimeMillis(); // Başlangıç zamanını al
        System.out.println(ebobFunc3(800000000,800000001));
        long endTime3 = System.currentTimeMillis(); // Bitiş zamanını al
        long elapsedTime3 = endTime3 - startTime3; // Toplam süreyi hesapla
        System.out.println("Kodun çalışma süresi: " + elapsedTime3 + " milisaniye");
    }
}