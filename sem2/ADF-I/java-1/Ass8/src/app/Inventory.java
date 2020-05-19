package app;

import goods.*;
import java.util.Scanner;

public class Inventory {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        LaptopCatalog p = new LaptopCatalog();
        String op = null;
        while (true) {
            System.out.println(">>>MENU<<<");
            System.out.println("1. Add a new laptop");
            System.out.println("2. Search laptop by name");
            System.out.println("3. Display all laptops");
            System.out.println("4. Remove a laptop by id");
            System.out.println("5. Exit");
            System.out.print(" Choose [1-5]: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    p.addLaptop();
                    break;
                case "2":
                    System.out.print("Nhap ten laptop: ");
                    p.search(sc.nextLine().trim());
                    break;
                case "3":
                    p.displayAll();
                    break;
                case "4":
                    System.out.println("Nhap id laptop muon xoa: ");
                    p.remove(sc.nextLine().trim());
                    break;
                case "5":
                    return;
                default:
                    System.out.println("Invalid");

            }
        }
    }

}
