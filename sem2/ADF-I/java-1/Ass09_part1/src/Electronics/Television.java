
package Electronics;

import Goods.*;
import java.util.Scanner;
public class Television extends Product implements ITax {
    public int price,QoH;
    public String brand;

    public Television() {
        accept();
    }
    
    

    public Television(int price, int QoH, String brand, String id, String name) {
        super(id, name);
        this.price = price;
        this.QoH = QoH;
        this.brand = brand;
    }
    
    @Override
    protected void accept(){
        super.accept();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter price: ");
        price = Integer.parseInt(scanner.nextLine().trim());
        System.out.print("Enter QoH: ");
        QoH = Integer.parseInt(scanner.nextLine().trim());
        System.out.print("Enter brand: ");
        brand = scanner.nextLine().trim();
    }
    
    
    @Override
    public void printInfo() {
        System.out.println("ID: "+id);
        System.out.println("Name: "+name);
        System.out.println("price: "+price);
        System.out.println("QoH: "+QoH);
        System.out.println("brand: "+brand);
    }

    @Override
    public float getCost() {
        return price+price*VAT_TAX_PERCENT;
    }
    
    
}
