package data;

import java.util.Scanner;

public class Product {

    public int id, price, qoh;
    public String name;

    public void input() {
        System.out.println("Nhap thong tin san pham: ");
        Scanner sc = new Scanner(System.in);
        while (true) {
            System.out.print("Nhap ten sp: ");
            name = sc.nextLine().trim();
            if (!name.isEmpty()) {
                break;
            }
            System.out.println("Khong dc de trong ten san pham");
        }

        while (true) {
            try {
                System.out.print("Nhap gia san pham: ");
                price = Integer.parseInt(sc.nextLine().trim());
                if (price >= 1 && price <= 1000) {
                    break;
                }
                System.out.println("Gia san pham tu 1 - 1000 ");
            } catch (Exception ex) {
                System.out.println("Loi: " + ex.getMessage());
            }
        }

        while (true) {
            try {
                System.out.print("Nhap QOH: ");
                qoh = Integer.parseInt(sc.nextLine().trim());
                if (qoh > 0) {
                    break;
                }
                System.out.println("qoh nen lon hon 0");
            } catch (Exception ex) {
                System.out.println("Loi: " + ex.getMessage());
            }
        }
    }

    @Override
    public String toString() {
        return String.format("%5d ,%-10s, %5d, %5d", id,name,price,qoh);
    }
    

}
