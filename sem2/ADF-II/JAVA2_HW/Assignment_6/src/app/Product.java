package app;

import java.util.Scanner;

public class Product {

    public String id, name;
    public int price;
    public float in_qty = 0f, out_qty = 0f;

    //input method
    public void input() {
        Scanner sc = new Scanner(System.in);
        while (true) {
            System.out.print("Enter product id: ");
            id = sc.nextLine().trim();
            if (java.util.regex.Pattern.matches("P\\d{3}", id)) {
                break;
            }
            System.out.println(">>> ID must be Pxxx (x is number) <<<");
        }
        while (true) {
            System.out.print("Enter product name: ");
            name = sc.nextLine().trim();
            if (!name.isEmpty()) {
                break;
            }
            System.out.println(">>> Name can not be blank <<<");
        }

        while (true) {
            System.out.print("Enter unit price: ");
            try {
                price = Integer.parseInt(sc.nextLine().trim());
                if (price >= 0) {
                    break;
                }
                System.out.println(">>> Price can not be negative <<<");
            } catch (NumberFormatException ex) {
                System.out.println("Loi: " + ex.getMessage());
            }
        }
    }
//end input()
    
    //output method
    public void output(){
        System.out.print("\n id: "+id);
        System.out.print(", Name: "+name);
        System.out.print(", Unit price: "+price);
        System.out.print(", Input quantity: "+in_qty);
        System.out.print(", Output quantity: "+out_qty);
        System.out.print(", qoh: "+(in_qty-out_qty));
        System.out.print(", amt: "+((in_qty-out_qty)*price)+"\n");
    }
    //end output
    
    //toString
    @Override
    public String toString() {
        return String.format("%s, %s, %d, %.2f, %.2f", id,name,price,in_qty,out_qty);
    }
    
    
    
}
