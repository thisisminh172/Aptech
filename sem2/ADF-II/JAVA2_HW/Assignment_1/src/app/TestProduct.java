
package app;

import java.util.Scanner;


public class TestProduct {

    
    public static void main(String[] args) {
        ProductList p = new ProductList();
        Scanner scanner = new Scanner(System.in);
        
        String op = "";
        while(true){
            System.out.println("===MENU===");
            System.out.println("1. Thêm 1 sản phẩm vô danh sách prList");
            System.out.println("2. Display all product");
            System.out.println("3. Search product by name");
            System.out.println("4. Exit");
            System.out.print("Choose your option[1-4]: ");
            op = scanner.nextLine().trim();
            
            switch(op){
                case "1":
                    p.addProduct();
                    break;
                case "2":
                    p.displayAll();
                    break;
                case "3":
                    System.out.print("Enter name for searching: ");
                    String name = scanner.nextLine().trim();
                    p.searchByName(name);
                    break;
                case "4":
                    return;
                default:
                    System.out.println("Invalid number");
            }
        }
    }
    
}
