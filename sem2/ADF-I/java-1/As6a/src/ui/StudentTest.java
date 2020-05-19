package ui;

import data.Student;
import java.util.Scanner;

public class StudentTest {

    int max = 3, count;

    Student[] ds;

    public StudentTest() {
        ds = new Student[max];
        count = 0;
    }

    //Hàm kiểm tra ds đã có sinh viên hay chưa
    //return true or false
    private boolean check() {
        if (ds.length > 0) {
            return true;
        }
        return false;
    }

    void add() {
        if (count == max) {
            System.out.println("full memory");
            return;
        }
        Student s = new Student();
        ds[count] = s;
        count++;
    }

    void display() {
        if (check()) {
            for (int i = 0; i < count; i++) {
                System.out.println(ds[i]);
            }
        } else {
            System.out.println("***********************");
            System.out.println("Không có sinh viên");
            System.out.println("***********************");
        }
    }

    void display(int m) {
        if (check()) {
            for (int i = 0; i < count; i++) {
                if (ds[i].average >= m) {
                    System.out.println(ds[i]);
                }
            }
        } else {
            System.out.println("***********************");
            System.out.println("Không có sinh viên");
            System.out.println("***********************");
        }

    }

    void display(String stName) {
        if (check()) {
            for (int i = 0; i < count; i++) {
                if (stName.equalsIgnoreCase(ds[i].name)) {
                    System.out.println(ds[i]);
                } else {
                    System.out.println("*****************************************");
                    System.out.println("Không tìm thấy sinh viên có tên " + stName);
                    System.out.println("*****************************************");
                }
            }
        } else {
            System.out.println("***********************");
            System.out.println("Không có sinh viên");
            System.out.println("***********************");
        }
    }

    void menu() {
        Scanner sc = new Scanner(System.in);
        String op = "";
        while (true) {
            System.out.println("=====MENU=====");
            System.out.println("1. Them sinh vien moi");
            System.out.println("2. In danh sach sinh vien");
            System.out.println("3. In danh sach sinh vien theo diem trung binh");
            System.out.println("4. Tim sinh vien theo ten");
            System.out.println("5. Thoat");
            System.out.print("Vui long chon chuc nang [1-5]: ");
            op = sc.nextLine().trim();

            switch (op) {
                case "1":
                    add();
                    break;
                case "2":
                    display();
                    break;
                case "3":
                    System.out.print("Nhap diem trung binh: ");
                    int av = Integer.parseInt(sc.nextLine().trim());
                    display(av);
                    break;
                case "4":
                    System.out.println("Nhap ten sinh vien");
                    String name = sc.nextLine().trim();
                    display(name);
                    break;
                case "5":
                    System.out.println("Kết thúc chương trình");
                    return;//ket thuc ham menu -> dung chuong trinh
            }
        }
    }

    public static void main(String[] args) {
        StudentTest m = new StudentTest();
        m.menu();
    }

}
