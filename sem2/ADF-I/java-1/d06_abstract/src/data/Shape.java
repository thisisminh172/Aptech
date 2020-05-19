/*
 * Day la lop truu tuong mo ta cau truc 1 doi tuong hinh hoc tong quat
 * co 2 ham tinh dien tich va tinh chu vi
 */
package data;

public abstract class Shape {

    public abstract double getArea();

    public abstract double getPeripheral();
    
    //ham truu tuong nhap du lieu cho 1 doi tuong hinh hoc bat ky
    public abstract void input();

    //ham in ra dien tich va chu cua 1 doi tuong hinh hoc
    public void output() {
        System.out.printf("Dien tich: %.2f \n", getArea());
        System.out.printf("Chu vi: %.2f \n", getPeripheral());
    }
}
