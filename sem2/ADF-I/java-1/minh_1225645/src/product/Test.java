
package product;

import java.util.Scanner;

public class Test {

   
    public static void main(String[] args) {
        Invoice m = new Invoice();
        Scanner scanner = new Scanner(System.in);
        String op = "";
        while(true){
            System.out.println("===MENU===");
            System.out.println("1. Create New Item");
            System.out.println("2. Search and display Item");
            System.out.println("3. Exit");
            System.out.print("Enter your option [1-3]: ");
            op = scanner.nextLine().trim();
            switch(op){
                case "1":
                    m.addItem();
                    break;
                case "2":
                    m.searchItem();
                    break;
                case "3":
                    System.out.println("Exit program");
                    return;
                default:
                    System.out.println("Invalid choice");
            }
        }
    }
    
}
