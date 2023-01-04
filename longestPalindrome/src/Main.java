import java.util.*;

// Soru Linki= https://leetcode.com/problems/longest-palindromic-substring/

public class Main {
    public static String longestPalindrome(String s) {

        // Bu kod bloğu ikili, üçlü... gibi string değeri parçalayıp liateye ekler
        if(s!=null && s.length()>1){
            ArrayList<String> arr=new ArrayList<String>();

            for (int i = 0; i < s.length(); i++) {
                for (int j = i + 1; j <= s.length(); j++) {
                    arr.add(s.substring(i, j));
                }
            }

            // Bu kod bloğu string değerlerin uzunluğunu karşılaştırır
            Comparator<String> comparator = new Comparator<String>() {
                public int compare(String s1, String s2) {
                    return s1.length() - s2.length();
                }
            };
            // Karşılaştırılan değerileri sıralar
            Collections.sort(arr, comparator);

            // Bu kod bloğu paçalanan verilerin en uzunundan başlayarak verininin tersiyle kaarşılaştırmasını yapar

            for (int i = arr.size() - 1; i >= 0; i--) {
                String str = arr.get(i);
                if (str.equals(new StringBuilder(str).reverse().toString())) {
                    return str;
                }
            }
        }
        else if(s!=null && s.length()==1){
            return s;
        }

        return s.substring(0,1);
    }


    public static void main(String []args){
        String s="racecar";
        System.out.println(longestPalindrome(s));
    }
}