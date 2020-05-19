package product;

import java.util.Scanner;

public class Invoice {

    public int nextItem = 0, maxItem = 10;
    Item[] arrItem = new Item[maxItem];

    public void addItem() {
        if (nextItem == maxItem) {
            System.out.println("Out of memory");
            return;
        }
        Item n = new Item();
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.print("Enter product's name: ");
            n.name = scanner.nextLine().trim();
            if(n.name.length()>0){
                break;
            }
            System.out.println("Name can not be blank.");
        }
        while (true) {
            try {
                System.out.print("Enter price: ");
                n.price = Integer.parseInt(scanner.nextLine().trim());
                if (n.price > 0) {
                    break;
                } else {
                    System.out.println("Price can't be negative number");
                }

            } catch (Exception e) {
                System.out.println("Error: " + e.getMessage());
            }
        }

        while (true) {
            try {
                System.out.print("Enter quantity: ");
                n.quantity = Integer.parseInt(scanner.nextLine().trim());
                if (n.quantity > 0) {
                    break;
                } else {
                    System.out.println("Quantity can't be negative number");
                }

            } catch (Exception e) {
                System.out.println("Error: " + e.getMessage());
            }
        }
        arrItem[nextItem] = n;
        nextItem++;
    }
    
    public void searchItem(){
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter name: ");
        String name = scanner.nextLine().trim();
        int count = 0;
        for (int i = 0; i < nextItem; i++) {
            if(arrItem[i].name.contains(name)){
                arrItem[i].displayDetails();
                count++;
            }
        }
        if(count==0){
            System.out.println("No item to display");
        }
    }
}
