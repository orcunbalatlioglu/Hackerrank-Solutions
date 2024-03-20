import java.util.*;
import java.text.*;

public class Solution {
    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double payment = scanner.nextDouble();
        scanner.close();
        Locale India = new Locale("en","IN");
        NumberFormat us = NumberFormat.getCurrencyInstance(Locale.US);
        NumberFormat ind = NumberFormat.getCurrencyInstance(India);
        NumberFormat ch = NumberFormat.getCurrencyInstance(Locale.CHINA);
        NumberFormat fr = NumberFormat.getCurrencyInstance(Locale.FRANCE); 
        
        System.out.println("US: " + us.format(payment));
        System.out.println("India: " + ind.format(payment));
        System.out.println("China: " + ch.format(payment));
        System.out.println("France: " + fr.format(payment));
    }
}