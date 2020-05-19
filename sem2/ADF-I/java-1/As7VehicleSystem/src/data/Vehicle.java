package data;

import java.util.Scanner;

public class Vehicle {

    protected String id, name, brand;
    protected float speed, weight, price;

    public Vehicle() {
    }

    public Vehicle(String id, String name, String brand, float speed, float weight, float price) {
        this.id = id;
        this.name = name;
        this.brand = brand;
        this.speed = speed;
        this.weight = weight;
        this.price = price;
    }
    
    //ham check null(String)
    boolean checkNullString(String s){
        return !"".equals(s);
    }

    protected void accept() {
        Scanner scanner = new Scanner(System.in);
        System.out.println(">>>Enter vehicle information<<<");
        while (true) {
            System.out.print("Enter id: ");
            id = scanner.nextLine().trim();
            System.out.print("Enter name: ");
            name = scanner.nextLine().trim();
            System.out.print("Enter brand: ");
            brand = scanner.nextLine().trim();
            if(checkNullString(id)&&checkNullString(name)&&checkNullString(brand)){
                break;
            }
            System.out.println("Can not leave empty info");
        }
        System.out.print("Enter speed[mph]: ");
        speed = Float.parseFloat(scanner.nextLine()); 
        System.out.print("Enter weight[kg]: ");
        weight = Float.parseFloat(scanner.nextLine()); 
        System.out.print("Enter price[$]: ");
        price = Float.parseFloat(scanner.nextLine()); 
    }
    
    public void printInfo(){
        System.out.println("id: "+id);
        System.out.println("name: "+name);
        System.out.println("brand: "+brand);
        System.out.println("speed: "+speed);
        System.out.println("weight: "+weight);
        System.out.println("price: "+price);
    }

}
