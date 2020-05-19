/**
 * vi du nhap 2 so nguyen in ra ket qua
 */
package demo;

import java.util.Scanner;

public class Example2 {

    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        //Xuat len man hinh 1 thong bao yeu cau nguoi dung nhap mot so nguyn
        System.out.print("Nhap so nguyen a: ");
        int n1 = sc.nextInt();

        System.out.print("Nhap so nguyen b: ");
        int n2 = sc.nextInt();

        //in ra ket qua cua phep toan cong 2 so
        //in ra ket qua a + b
        System.out.printf("%d + %d = %d \n", n1, n2, n1 + n2);
        System.out.printf("%d - %d = %d \n", n1, n2, n1 - n2);
        System.out.printf("%d * %d = %d \n", n1, n2, n1 * n2);
        System.out.printf("%d / %d = %d \n", n1, n2, n1 / n2);
        System.out.printf("%d %% %d = %d \n", n1, n2, n1 % n2);
        System.out.println("Phep toan luan ly nhi phan");
        System.out.printf("%d & %d = %d \n", n1, n2, n1 & n2);
        System.out.printf("%d | %d = %d \n", n1, n2, n1 | n2);
        System.out.printf("%d ^ %d = %d \n", n1, n2, n1 ^ n2);
        
        /**
         *n1 = 22  = 0001 0110
         * n2 = 17 = 0001 0001
         * n1 & n2 = 0001 0000
         * n1 | n2 = 0001 0111
         * n1 ^ n2 = 0000 0111
         * 
         * he thong so thap phan [0-9]
         * 1567 = 1000   + 500    + 60     + 7
         *      = 1*10^3 + 5*10^2 + 6*10^1 + 7*10^0
         */

    }

}
