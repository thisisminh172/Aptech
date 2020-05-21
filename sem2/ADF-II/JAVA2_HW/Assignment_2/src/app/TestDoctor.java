package app;

import java.util.Scanner;

public class TestDoctor {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        DoctorList m = new DoctorList();
        String op = "";
        while (true) {
            System.out.println("==MENU==");
            System.out.println("1. Add a new doctor");
            System.out.println("2. remove a doctor by id");
            System.out.println("3. Display level 2 doctor");
            System.out.println("4. Search doctor by name");
            System.out.println("5. Exit");
            System.out.print("Choose your option: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    m.add();
                    break;
                case "2":
                    System.out.print("Enter id you want to delete: ");
                    String drID = sc.nextLine().trim();
                    m.remove(drID);
                    break;
                case "3":
                    m.display();
                    break;
                case "4":
                    System.out.print("Enter the doctor name: ");
                    String drName = sc.nextLine().toLowerCase().trim();
                    m.display(drName);
                    break;
                case "5":
                    return;
                default:
                    System.out.println("Invalid number");
            }
        }
    }

}
