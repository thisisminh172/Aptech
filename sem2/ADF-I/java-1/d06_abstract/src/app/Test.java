/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app;

import java.util.Scanner;

public class Test {

    public static void main(String[] args) {
        ShapeCatalog o = new ShapeCatalog();
        String op = "";
        Scanner sc = new Scanner(System.in);
        while (true) {
            System.out.println("\n ===MENU===");
            System.out.println("1. Them hinh chu nhat");
            System.out.println("2. Them hinh tron");
            System.out.println("3. in danh sach cac doi tuong");
            System.out.println("4. In ra danh sách các hình vuông");
            System.out.println("5. thoat");
            System.out.print("Vui long chon chuc nang: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    o.addRect();
                    break;
                case "2":
                    o.addCircle();
                    break;
                case "3":
                    o.display();
                    break;
                case "4":
                    o.displaySquare();
                    break;
                case "5":
                    return;
                default:
                    System.out.println("nhap sai");
                    
            }

        }

    }

}
