
package data;

import java.util.Scanner;


public class Car extends Vehicle {
    private boolean GPS;
    Scanner sc = new Scanner(System.in);
    public Car(){
        
    }
    public Car(String id, String name, String brand, float speed, float weight, float price,boolean GPS) {
        super(id, name, brand, speed, weight, price);
        this.GPS = GPS;
    }
    
    public boolean getGPSStatus(){
        return this.GPS;
    }

    @Override
    protected void accept() {
        super.accept();
        System.out.print("GPS[true|false]: ");
        GPS = sc.nextBoolean();
    }

    @Override
    public void printInfo() {
        super.printInfo();
        System.out.println("GPS: "+GPS);
    }

    @Override
    public String toString() {
        return id+", "+name+", "+brand+", "+speed+", "+weight+", "+price+", "+ "Car{" + "GPS=" + GPS + '}';
    }
    
    
    
}
