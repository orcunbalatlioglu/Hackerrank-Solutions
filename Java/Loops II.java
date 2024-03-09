import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in); 
        int inputCount = in.nextInt();
        for (int i = 1; i <= inputCount; i++){
            int ValueA = in.nextInt();
            int ValueB = in.nextInt();
            int ValueN = in.nextInt();
            
            int result = ValueA;
            for(int j = 0; j < ValueN; j++)
            {
                result += ValueB * Math.pow(2,j); 
                System.out.print(result + " ");
            }
            System.out.println();
        }
    }
}