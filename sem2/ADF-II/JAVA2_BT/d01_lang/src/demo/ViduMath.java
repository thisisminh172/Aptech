package demo;

import java.util.Scanner;

public class ViduMath {

    public static void main(String[] args) {
        java.util.Scanner scanner = new Scanner(System.in);
        System.out.print("Nhap 1 so: ");
        int n = Integer.parseInt(scanner.nextLine().trim());
        double x = Math.sqrt(n);
        System.out.printf("\ncan bac 2 cua %d = %.2f \n", n, x);

        System.out.println("so san (floor): " + Math.floor(x));//return double
        System.out.println("so tran (ceil): " + Math.ceil(x));//return double
        System.out.println("so lam tron (round): " + Math.round(x));//return long
        int a =5,b=3;
        System.out.printf("luy thua %d^%d: pow(%d,%d) = %f\n",a,b,a,b,Math.pow(a, b));
        
        float r;
        System.out.printf("\nso ngau nhien [0-1]: %f \n", Math.random());
        
        System.out.println("- 5 so ngau nhien bat ky: ");
        for (int i = 0; i < 5; i++) {
            System.out.printf("\t%f\n",Math.random());
        }
        
        System.out.println("- 5 so ngau nhien bat ky từ [0-100]: ");
        for (int i = 0; i < 5; i++) {
            System.out.printf("\t%d\n",Math.round(Math.random()*100));
        }
        
        System.out.println("- 5 so ngau nhien bat ky từ [10-50]: ");
        for (int i = 0; i < 5; i++) {
            System.out.printf("\t%d\n",Math.round(Math.random()*40+10));
        }
    }

}
