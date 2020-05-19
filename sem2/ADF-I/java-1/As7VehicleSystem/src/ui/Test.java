
package ui;

import data.*;
import java.util.Scanner;
public class Test {

    
    public static void main(String[] args) {
        VehicleCatalog v = new VehicleCatalog();
        String op = "";
        Scanner sc = new Scanner(System.in);
        while(true){
            System.out.println("MENU");
            System.out.println("1.Add a new car");
            System.out.println("2. Display all cars");
            System.out.println("3. Search car by brand name");
            System.out.println("4. Display all cars having GPS module");
            System.out.println("5. Display high-rank vehicle");
            System.out.println("6. Exit");
            System.out.print("Enter feature from range[1-6]: ");
            op = sc.nextLine().trim();
            switch(op){
                case "1":
                    v.addCar();
                    break;
                case "2":
                    v.displayAll();
                    break;
                case "3":
                    System.out.print("Enter brand name: ");
                    String bn = sc.nextLine().trim();
                    v.searchByBrand(bn);
                    break;
                case "4":
                    v.displayAllGPSCar();
                    break;
                case "5":
                    v.displayHighRankl();
                    break;
                case "6":
                    return;
                default: 
                    System.out.println("Invalid number");
                
            }
        }
    }
    
}
