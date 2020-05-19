/*
 * mo ta cau truc du lieu cua 1 doi tuong nhan vien, bao gom:
 * field du lieu: ma so, ten, luong cb,so ngay lam viec
 * phuong thuc xu ly: nhap(),xuat()
 */
package basic;

import java.util.Scanner;


public class Employee implements IPayable{
    public String id,name;
    public int basicSalary,workDays;
    
    public Employee(){
        
    }

    public Employee(String id, String name, int basicSalary, int workDays) {
        this.id = id;
        this.name = name;
        this.basicSalary = basicSalary;
        this.workDays = workDays;
    }
    
    public void input(){
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter ID: ");
        id = scanner.nextLine().trim();
        System.out.print("Enter name: ");
        name = scanner.nextLine().trim();
        System.out.print("Enter basic salary: ");
        basicSalary = Integer.parseInt(scanner.nextLine().trim());
        System.out.print("Enter work days: ");
        workDays = Integer.parseInt(scanner.nextLine().trim());
    }
    
    public void output(){
        System.out.println(">>bang luong cong nhan: ");
        System.out.println("id: "+id);
        System.out.println("name: "+name);
        System.out.println("luong cb: "+basicSalary);
        System.out.println("ngay lam viec: "+workDays);
        //System.out.println("thoi vu: "+partTime);
        System.out.println("Luong thang: "+getSalary());
        System.out.println("thue thu nhap: "+getTax());
        System.out.println("Thuc lanh: "+(getSalary()-getTax()));
    }

    @Override
    public String toString() {
        return super.toString(); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public float getSalary() {
        float temp = 0;
        temp = basicSalary * workDays/24;
        if(workDays>24){
            temp += (basicSalary/24*(workDays-24)*OT);
        }
        return temp;
    }

    @Override
    public float getTax() {
        float temp = 0;
        if(getSalary()>1000){
            temp = getSalary() * 0.2f;
        }else if(getSalary()>500){
            temp = getSalary() * 0.1f;
        }
        return temp;
    }
    
    
}
