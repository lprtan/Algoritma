
import java.util.*;
public class Main {
    public static List<Integer> selectionSort(List<Integer> list) {
        List<Integer> sortList = new ArrayList<>();
        int i = 0;
        int indexNo = 0;

        while (true) {
            int min = list.get(i);

            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(j) < min) {
                    min = list.get(j);
                    indexNo = list.indexOf(min);
                }
            }

            sortList.add(min);
            list.remove(Integer.valueOf(min));

            if (list.size() == 0) {
                break;
            }
        }

        return sortList; // sıralanmış liste geri dönüş değeri olarak döndürülüyor
    }

    public static void main(String[] args) {
        List<Integer> list = new ArrayList<>();
        list.add(63);
        list.add(8);
        list.add(5);
        list.add(2);
        list.add(10);
        list.add(1);
        List<Integer> newList = new ArrayList<>();
         newList=selectionSort(list);

        System.out.println("Sıralanmış liste:");

        for (int item: newList) {
            System.out.print(item+" ");
        }
    }
}