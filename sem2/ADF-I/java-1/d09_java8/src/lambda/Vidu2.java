/*
 * Demo ve method references
 */
package lambda;

import java.util.function.*;
public class Vidu2 {

    
    public static void main(String[] args) {
        Vidu2 p = new Vidu2();
        p.demoStatic();
        p.demoInstance();
    }
    
    void demoStatic(){
        int a = 60;
        //ap dung bieu thuc lambda de in gia tri 1  so nguyen duoi dang nhi phan
        Function<Integer, String> ex1 = n -> Integer.toBinaryString(n);
        System.out.printf("%d(d) = %s(b)\n",a,ex1.apply(a));//this will autoboxing from int a to Integer a
        
        //ap dung method reference de rut gon bt lambda
        Function<Integer,String> ex2 = Integer::toBinaryString;
        System.out.printf("%d(d) = %s(b)\n",a,ex2.apply(a));
    }
    
    void demoInstance(){
        String name ="le minh";
        //bt lambda de in ra chu IN HOA
        Supplier<String> ex1 = () -> name.toUpperCase();
        System.out.println("your name: "+ ex1.get());
        
        //method reference
        Supplier<String> ex2 = name::toUpperCase;
        System.out.println("your name: "+ex2.get());
        
    }
    
}
