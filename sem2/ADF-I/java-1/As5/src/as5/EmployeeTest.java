package as5;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class EmployeeTest {

    //I.ArrayList
    List<Employee> empList;

    //II. Ham dung khong tham so
    public EmployeeTest() {
        empList = new ArrayList<Employee>();
    }

    //III
    //1.add()
    void add() {
        int temp = 0;
        Employee e = new Employee();
        e.input();
        //check: nếu có nhân viên sẽ xét dk trùng id
        if (empList.size() > 0) {
            for (int i = 0; i < empList.size(); i++) {
                if (e.id.equalsIgnoreCase(empList.get(i).id)) {
                    temp++;
                }
            }
        }

        if (temp != 0) {
            System.out.println("********************");
            System.out.println("không thêm mới được");
            System.out.println("********************");
        } else {
            empList.add(e);//thuc hien khi la nhan vien dau tien
        }

    }

    //2.display()
    void display() {
        if (empList.size() > 0) {
            for (Employee emp : empList) {
                System.out.println(emp);
            }
        } else {
            System.out.println("*****************************************");
            System.out.println("Không có nhân viên nào trong danh sách");
            System.out.println("*****************************************");
        }
    }

    //3.display(int amt)
    void display(int amt) {
        for (Employee emp : empList) {
            if (amt == emp.baseSalary) {
                System.out.println(emp);
            }
        }
    }

    //4. display(String empName)
    void display(String empName) {
        for (Employee emp : empList) {
            if (empName.equalsIgnoreCase(emp.name)) {
                System.out.println(emp);
            }
        }
    }

    //5.menu()
    void menu() {
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.println("=======MENU=======");
            System.out.println("1. Thêm nhân viên");
            System.out.println("2. In danh sách nhân viên");
            System.out.println("3. Tìm nhân viên theo lương");
            System.out.println("4. Tìm nhân viên theo tên");
            System.out.println("5. Thoát chương trình");
            System.out.print("Chọn chức năng [1-5]: ");
            String op = sc.nextLine().trim();

            switch (op) {
                case "1":
                    add();
                    break;
                case "2":
                    display();
                    break;
                case "3":
                    System.out.print("Nhập số lương: ");
                    int amt = Integer.parseInt(sc.nextLine().trim());
                    display(amt);
                    break;
                case "4":
                    System.out.print("Nhập tên nhân viên: ");
                    String name = sc.nextLine().trim();
                    display(name);
                    break;
                case "5":
                    System.out.println("Kết thúc chương trình");
                    return;
                default:
                    System.out.println("Nhập không đúng chức năng");
                    break;
            }
        }

    }

    public static void main(String[] args) {
        EmployeeTest m = new EmployeeTest();
        m.menu();
    }

}
