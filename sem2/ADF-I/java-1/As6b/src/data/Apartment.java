package data;

import java.util.Scanner;

public class Apartment {

    public String id, owner, address;
    public float width, length;

    public Apartment() {
        input();
    }

    public Apartment(String id, String owner, String address, float width, float length) {
        this.id = id;
        this.owner = owner;
        this.address = address;
        this.width = width;
        this.length = length;
    }

    private void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter apartment's id: ");
        id = sc.nextLine().trim();
        System.out.print("Enter owner: ");
        owner = sc.nextLine().trim();
        System.out.print("Enter address: ");
        address = sc.nextLine().trim();
        System.out.print("Enter width: ");
        width = sc.nextFloat();
        System.out.print("Enter length: ");
        length = sc.nextFloat();
    }
    
    public void print(){
        System.out.println("ID: "+id);
        System.out.println("Owner: "+owner);
        System.out.println("Address: "+address);
        System.out.println("W: "+width);
        System.out.println("L: "+length);
    }
    
    public boolean isSquare(){
        return width == length;
    }
    
    public float getArea(){
        return width*length;
    }
    
    public float getPeripheral(){
        return 2*(width+length);
    }

    @Override
    public String toString() {
        return "Apartment{" + "id=" + id + ", owner=" + owner + ", address=" + address + ", width=" + width + ", length=" + length + '}';
    }
    
}
