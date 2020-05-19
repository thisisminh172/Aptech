/*
 * mo ta 1 may tinh
 * thuoc tinh : id, price, brand
 * phuong thuc xu ly : input(), display()
 */
package data;

import java.util.Scanner;

public class Computer {

    //khai bao cac thuoc tinh
    public String id, brand;
    public int price;

    //ham dung
    public Computer() {
        id = "C01";
        brand = "Asus";
        price = 100;
    }

    public Computer(String id, String brand, int price) {
        this.id = id;
        this.brand = brand;
        this.price = price;
    }

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter computer's ID: ");
        id = sc.nextLine().trim();
        System.out.print("Enter computer's brand: ");
        brand = sc.nextLine().trim();
        //nhap gia tri hop le(50-5000)
        while (true) {
            System.out.print("Enter computer's price[50-5000]: ");

            price = Integer.parseInt(sc.nextLine().trim());
            if (price >= 50 && price <= 5000) {
                break;
            }
            System.out.println("Gia tri lhong hop le");
        }
    }

    public void display() {
        System.out.println("Thong tin may tinh: ");
        System.out.println("ID: " + id);
        System.out.println("Brand: " + brand);
        System.out.println("Price: $" + price);

    }

    @Override
    public String toString() {
        return "Computer{" + "id=" + id + ", brand=" + brand + ", price=" + price + '}';
    }
    
    
}
