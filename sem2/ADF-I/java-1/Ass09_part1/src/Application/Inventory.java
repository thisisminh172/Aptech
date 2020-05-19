
package Application;

import Electronics.TelevisionCatalog;
import java.util.Scanner;
public class Inventory {

    
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TelevisionCatalog m = new TelevisionCatalog();
        String op = "";
        while(true){
            System.out.println("===MENU===");
            System.out.println("1. Add a new television");
            System.out.println("2. Search television by brand");
            System.out.println("3. Display all televisions");
            System.out.println("4. Display high-valued televisions");
            System.out.println("5. Exit");
            System.out.print("Please choose number[1-5]: ");
            op = scanner.nextLine().trim();
            switch(op){
                case "1":
                    m.add();
                    break;
                case "2":
                    m.searchByBrand();
                    break;
                case "3":
                    m.displayAll();
                    break;
                case "4":
                    m.displayHighValue();
                    break;
                case "5":
                    System.out.println("end program");
                    return;
                default:
                    System.out.println("Invalid value");
            }
        }
    }
    
}
