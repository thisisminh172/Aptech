/*
mo ta cau truc du lieu cua 1 cong nhan
field du lieu maso, ho ten, luong can ban, so ngay lam viec, ban thoi gian, hop dong chinh thuc
ham xu ly : nhap(), xuat()
 */
package basic;

import java.util.Scanner;

public class Worker implements IPayable {

    public String id, name;
    public int salary, workDays;
    public boolean partTime;

    public Worker() {
    }

    public Worker(String id, String name, int salary, int workDays, boolean partTime) {
        this.id = id;
        this.name = name;
        this.salary = salary;
        this.workDays = workDays;
        this.partTime = partTime;
    }

    public void input() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter ID: ");
        id = scanner.nextLine().trim();
        System.out.print("Enter name: ");
        name = scanner.nextLine().trim();
        System.out.print("Enter basic salary: ");
        salary = Integer.parseInt(scanner.nextLine().trim());
        System.out.print("Enter work days: ");
        workDays = Integer.parseInt(scanner.nextLine().trim());
        System.out.println("Hop dong thoi vu[y/n]: ");
        partTime = scanner.nextLine().trim().equalsIgnoreCase("y");
    }

    @Override
    public float getSalary() {
        return salary * workDays / 24;
    }

    @Override
    public float getTax() {
        float temp = 0;
        if (partTime==false && getSalary() > 1000) {
            temp = getSalary() * 0.1f;
        }
        return temp;
    }
    
    public void output(){
        System.out.println(">>bang luong cong nhan: ");
        System.out.println("id: "+id);
        System.out.println("name: "+name);
        System.out.println("luong cb: "+salary);
        System.out.println("ngay lam viec: "+workDays);
        System.out.println("thoi vu: "+partTime);
        System.out.println("Luong thang: "+getSalary());
        System.out.println("thue thu nhap: "+getTax());
        System.out.println("Thuc lanh: "+(getSalary()-getTax()));
    }

    @Override
    public String toString() {
        return String.format("%s, %s, %.2f", id, name, getSalary()-getTax());
    }
    
    
}
