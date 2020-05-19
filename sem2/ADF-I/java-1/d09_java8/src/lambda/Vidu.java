/**
 * demo cach lap trinh bieu thuc lambda (ham an danh)
 * 1. Phai co (tao) 1 functional interface (chi co 1 ham truu truong duy nhat)
 * 2. tao bieu thuc lambda dua tren functional interface o buoc 1
 * 3. cho thi hanh bieu thuc lambda
 */
package lambda;

import java.util.Scanner;

public class Vidu {

    public static void main(String[] args) {
        //2. tao bieu thuc lambda dua tren functional interface ICasio
        ICasio ex1 = (int x, int y) -> {
            return x + y;
        };
        ICasio ex2 = (x, y) -> {
            return x * y;
        };
        
        ICasio ex3 = (x,y) -> x/y;
        ICasio ex4 = (x,y) -> {
            return x%y;
        };
        
        //neu khong co bieu thuc 
        ICasio ex5 = new ICasio(){
            @Override
            public int op(int a, int b){
                return a-b;
            }
        };
        
        java.util.Scanner sc = new Scanner(System.in);
        System.out.print("Nhap so nguyen thu 1: "); int a = Integer.parseInt(sc.nextLine().trim());
        System.out.print("Nhap so nguyen thu 2: "); int b = Integer.parseInt(sc.nextLine().trim());

        //3. thuc hien bt lambda
        int kq1 = ex1.op(a, b);
        System.out.printf("%d + %d = %d \n",a,b,kq1);
        int kq2 = ex2.op(a, b);
        System.out.printf("%d * %d = %d \n",a,b,kq2);
        
        System.out.printf("%d / %d = %d \n",a,b,ex3.op(a, b));
        System.out.printf("%d - %d = %d \n",a,b,ex5.op(a, b));
    }

}

//dinh nghia functional interface
@FunctionalInterface
interface ICasio {

    public int op(int a, int b);
}
