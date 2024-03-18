import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
private static boolean flag = true;
private static int B, H; 

static{
    Scanner sc = new Scanner(System.in);
    B = sc.nextInt();
    H = sc.nextInt();
    sc.close();
    try{
        if(B <= 0 || H <= 0){
            throw new Exception("Breadth and height must be positive");
        }
        
    }
    catch(Exception ex){
        System.out.print(ex);
        flag = false;
    }
    
}

public static void main(String[] args){
		if(flag){
			int area=B*H;
			System.out.print(area);
		}
		
	}//end of main

}//end of class

