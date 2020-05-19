
package Goods;

import java.util.Scanner;


public abstract class Product {
    protected String id,name;

    public Product() {
    }
    

    public Product(String id, String name) {
        this.id = id;
        this.name = name;
    }
    protected void accept(){
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter product's id: ");
        id = scanner.nextLine().trim();
        System.out.print("Enter product's name: ");
        name = scanner.nextLine().trim();
    }
    
    public abstract void printInfo();
}
