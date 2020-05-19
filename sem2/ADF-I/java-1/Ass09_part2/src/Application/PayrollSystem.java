package Application;

import data.EmployeeCatalog;
import java.util.Scanner;

public class PayrollSystem {

    public static void main(String[] args) {
        EmployeeCatalog m = new EmployeeCatalog();
        Scanner scanner = new Scanner(System.in);
        String op = "";
        while (true) {
            System.out.println("===MENU===");
            System.out.println("1. Add a new worker");
            System.out.println("2. Add a new engineer");
            System.out.println("3. Display all employees");
            System.out.println("4. Display list of workers");
            System.out.println("5. Display list of engineers");
            System.out.println("6. Display the pay slip of any employee by name");
            System.out.println("7. Exit");
            System.out.print("Enter your option [1-7]>>> ");
            op = scanner.nextLine().trim();
            switch (op) {
                case "1":
                    m.addWorker();
                    break;
                case "2":
                    m.addEngineer();
                    break;
                case "3":
                    m.display();
                    break;
                case "4":
                    m.display(true);
                    break;
                case "5":
                    m.display(false);
                    break;
                case "6":
                    System.out.print("Enter the name: ");
                    String name = scanner.nextLine().trim();
                    m.display(name);
                    break;
                case "7":return;
                default: System.out.println("Invalid number");

            }
        }

    }

}
