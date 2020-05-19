/*
 * 
 */
package goods;

import java.util.Scanner;

public abstract class Computer {

    public String id, name;
    public int price;

    public Computer() {
    }

    public Computer(String ID, String name, int price) {
        this.id = ID;
        this.name = name;
        this.price = price;
    }

    public void accept() {
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.print("Nhap ma so: ");
            id = sc.nextLine().trim();
            if (id.length() > 0) {
                break;
            }
            System.out.println("Ma so khong hop le");
        }

        while (true) {
            System.out.print("Nhap ten san pham: ");
            name = sc.nextLine().trim();
            if (name.length() > 0) {
                break;
            }
            System.out.println("Ten khong hop le");
        }

        while (true) {
            try {
                System.out.print("Nhap gia san pham: ");
                price = Integer.parseInt(sc.nextLine().trim());
                if (price > 0) {
                    break;
                }
                System.out.println("don gia khong hop le");
            }catch (Exception e){
                System.out.println("Loi sai: "+e.getMessage());
            }

        }
    }
    
    public abstract void printInfo();
}
