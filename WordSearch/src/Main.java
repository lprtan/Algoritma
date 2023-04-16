import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
    // Soru link: https://leetcode.com/problems/word-search/solutions/
    public static boolean exist(char[][] board, String word) {
        List<Character> listBoardWord=new ArrayList<Character>();
        List<Character> list=new ArrayList<Character>();
        String newWord="";

        for(int i=0; i<board.length; i++){
            for(int j=0; j<board[i].length; j++){
                listBoardWord.add(board[i][j]);
            }
        }

        for (int i=0;i<word.length();i++){
            for (int j=0; j<listBoardWord.size();j++){
                if(word.charAt(i) == listBoardWord.get(j)){
                    list.add(listBoardWord.get(j));
                    listBoardWord.remove(j);
                    break;
                }
            }
        }

        for (char item: list) {
            newWord+=item;
        }

        if(word.equals(newWord)){
            return true;
        }
        return false;
    }

    public static void main(String[] args) {
        //char[][] board = {{'A','B','C','E'},{'S','F','C','S'},{'A','D','E','E'}};
        char[][] board = {{'A','B'},{'C','D'}};

        System.out.println(exist(board, "ABCD"));
    }
}