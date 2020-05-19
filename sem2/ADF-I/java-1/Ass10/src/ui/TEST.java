
package ui;
import data.CustomerCatalog;
import java.util.Scanner;

public class TEST {

    
    public static void main(String[] args) {
        CustomerCatalog m = new CustomerCatalog();
        Scanner scanner = new Scanner(System.in);
        String op = "";
        while(true){
            System.out.println("=== MENU ===");
            System.out.println("1. Add a new customer");
            System.out.println("2. Search customer by name");
            System.out.println("3. Display all customers");
            System.out.println("4. Exit");
            System.out.print("Enter your option: ");
            op = scanner.nextLine().trim();
            switch(op){
                case "1":
                    m.add();
                    break;
                case "2":
                    System.out.print("Enter customer name: ");
                    String name = scanner.nextLine().trim();
                    m.searchByName(name);
                    break;
                case "3":
                    m.displayAll();
                    break;
                case "4":
                    return;
                default:
                    System.out.println("Invalid option");
                
            }
        }
    }
    
}
