/*
Tạo Java Class Employee để mô tả cấu trúc 1 nhân viên như sau:
    i. Dữ liệu (fields – variable): id, name, position, baseSalary (100- 2000USD)
    ii. Hàm dựng (constructors):
        1. Không tham số Employee()
        2. Có tham số Employee(String, String, String, int)
    iii. Phương thức:
        1. void input() : nhập dữ liệu cho các thuộc tính của nhân viên
        2. void print() : xuất thông tin chi tiết của đối tượng nhân viên
 */
package as5;

import java.util.Scanner;

public class Employee {

    //i. fields
    String id, name, position;
    int baseSalary;

    //ii. hàm dựng(constructors)
    //1.không tham số
    public Employee() {
    }

    //2.có tham số
    public Employee(String id, String name, String position, int baseSalary) {
        this.id = id;
        this.name = name;
        this.position = position;
        this.baseSalary = baseSalary;
    }

    //iii. phương thức
    //1. input()
    void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter employee's ID: ");
        id = sc.nextLine().trim();
        System.out.print("Enter employee's name: ");
        name = sc.nextLine().trim();
        System.out.print("Enter employee's position: ");
        position = sc.nextLine().trim();
        System.out.print("Enter employee's salary: ");
        baseSalary = Integer.parseInt(sc.nextLine().trim());
    }

    //2. print()
    void print() {
        System.out.println("Employee's ID: " + id);
        System.out.println("Employee's name: " + name);
        System.out.println("Employee's position: " + position);
        System.out.println("Employee's salary: " + baseSalary);
    }
    
    @Override
    public String toString(){
        return String.format("%s, %s, %s, %d", id, name, position, baseSalary);
    }
}
