/**
 * mo ta cau truc cua mot doi tuong laptop
 * day la lop con cua lop computer - duoc ke thua cac thuoc tinh
 * va phuong thuc cua lop cha
 */
package data;

import java.util.Scanner;


public class Laptop extends Computer {
    public float size, weight;

    @Override
    public void input() {
        super.input(); //gọi vao input() cua lop cha Computer de thuc hien lenh nhap 3 thuoc tinh id,  brand, price
        Scanner sc = new Scanner(System.in);
        //Nhap them gia tri 2 thuoc tinh moi
        System.out.print("Nhap kich thuoc: ");
        size = Float.parseFloat(sc.nextLine().trim());
        System.out.print("Nhap trong luong: ");
        weight = Float.parseFloat(sc.nextLine().trim());
        
    }

    @Override
    public void display() {
        super.display(); //To change body of generated methods, choose Tools | Templates.
        //in them 2 thuoc tinh moi cua lop con Laptop
        System.out.println("Kich thuoc: "+size);
        System.out.println("Can nang: "+weight);
    }
    
    
    
}
