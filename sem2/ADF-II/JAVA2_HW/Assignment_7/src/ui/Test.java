package ui;

import java.util.Scanner;
import model.*;

public class Test {

    public static void main(String[] args) {
        Test m = new Test();
        m.menu();
    }

    void menu() {
        Scanner sc = new Scanner(System.in);

        String op = "";
        while (true) {
            ProjectDAO pd = new ProjectDAO();

            System.out.println("===MENU===");
            System.out.println("1. Add a new project");
            System.out.println("2. Xoa project bang id");
            System.out.println("3. Danh sach du an");
            System.out.println("4. Danh sach du an da hoan thanh");
            System.out.println("5. Exit");
            System.out.print(">>> Chon [1-5]: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    Project p = new Project();
                    p.input();
                    pd.insert(p);
                    break;
                case "2":
                    System.out.println("Nhap id project muon xoa");
                    pd.delete(sc.nextLine().trim());
                    break;
                case "3":
                    System.out.println("Danh sach tat ca project");
                    ProjectDAO.getList().stream().forEach(System.out::println);
                    break;
                case "4":
                    System.out.println("Danh sach du an da hoan thanh");
                    ProjectDAO.getCompletedProject().stream().forEach(System.out::println);
                    break;
                case "5":
                    return;
                default :
                    System.out.println(">>> invalid number <<<");
            }
        }
    }

}
