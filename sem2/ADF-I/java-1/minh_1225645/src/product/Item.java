
package product;

import sale.IDiscount;
public class Item implements IDiscount {
    public String name;
    public int price, quantity;
    
    @Override
    public void displayDetails() {
        System.out.println("Name of product: "+name);
        System.out.println("Price: $"+price);
        System.out.println("Quantity: "+quantity);
        System.out.println("Total: $"+price*quantity);
    }
    
    
    
}
