/*
 * 
 */
package data;

import java.io.IOException;
import java.util.Scanner;

public class TEST {

    public static void main(String[] args) throws IOException {
        TEST o = new TEST();
        o.menu();
    }

    void menu() throws IOException {
        ProductList p = new ProductList();
        p.LoadFileText();
        Scanner sc = new Scanner(System.in);
        String op = "";
      
        while (true) {
            System.out.println("\nMENU");
            System.out.println("1. them san pham");
            System.out.println("2. xem danh sach");
            System.out.println("3. save");
            System.out.println("4. Open");
            System.out.println("5. Exit");
            System.out.print("Vui long nhap chuc nang [1-4]: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    p.add();
                    break;
                case "2":
                    
                    p.display();
                    break;
                case "3":
                    p.SaveFileText();
                    break;
                case "4":
                    Runtime r = Runtime.getRuntime();
                    r.exec("notepad " + "SanPham.txt");
                    break;
                case "5":
                    return;
                default:
                    System.out.println("invalid");

            }
        }

    }

}
