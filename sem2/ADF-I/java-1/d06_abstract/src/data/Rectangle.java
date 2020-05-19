/*
 * mo ta cau truc 1 doi tuong hinh chu nhat, la con cua lop Shape
 * co 2 thuoc tinh chieu dai va chieu rong
 */
package data;

import java.util.Scanner;


public class Rectangle extends Shape {
    public int width, length;
    
    
    @Override
    public double getArea() {
        return width * length;
    }

    @Override
    public double getPeripheral() {
        return (width+length)*2;
    }
    
    @Override
    public void input(){
        Scanner sc = new Scanner(System.in);
        System.out.print("Nhap chieu rong: ");
        width = Integer.parseInt( sc.nextLine().trim());
        System.out.print("Nhap chieu dai: ");
        length = Integer.parseInt( sc.nextLine().trim());
    }

    @Override
    public void output() {
        System.out.println("Thong tin hinh chu nhat");
        super.output();
    }
    
    
}
