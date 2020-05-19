/*
 * Mo ta cau truc hinh tron
 */
package data;

import java.util.Scanner;


public class Circle extends Shape {
    public float radius;

    @Override
    public double getArea() {
        return 3.14*radius*radius;
    }

    @Override
    public double getPeripheral() {
        return 2*3.14*radius;
    }
    
    @Override
    public void input(){
        Scanner sc = new Scanner(System.in);
        System.out.print("Nhap ban kinh hinh tron: ");
        radius = Float.parseFloat(sc.nextLine().trim());
    }

    @Override
    public void output() {
        System.out.println("Thông tin hình tròn");
        super.output();
    }
    
}
