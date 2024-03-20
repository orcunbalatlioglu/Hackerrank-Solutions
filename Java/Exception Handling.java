import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.lang.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner sc = new Scanner(System.in);
        List<String> inputList = new ArrayList<String>();
        while(sc.hasNext()){
            String input = sc.next();
            inputList.add(input);
        }
        List<Integer> numbers = new ArrayList<Integer>();
        try{
            try{
                for (String item : inputList) {
                    int value = Integer.parseInt(item);
                    numbers.add(value); 
                }
                int firstValue = numbers.get(0);
                int secondValue = numbers.get(1);
                if(numbers.get(1) == 0){
                    throw new ArithmeticException("/ by zero");
                }
                System.out.print(firstValue/secondValue);
            }
            catch(NumberFormatException ex){
                throw new InputMismatchException();
            }
        }
        catch(Exception ex){
            System.out.println(ex);
        }
    }
}