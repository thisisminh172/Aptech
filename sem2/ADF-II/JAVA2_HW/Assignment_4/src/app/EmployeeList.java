package app;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.PrintStream;
import java.util.HashSet;
import java.util.Scanner;

public class EmployeeList {

    public static void main(String[] args) {
        EmployeeList m = new EmployeeList();
        m.menu();
    }

    HashSet<Employee> empList;

    public EmployeeList() {
        //empList = new HashSet<>();
        readFileText();

    }

    public void addEmp() {
        Employee e = new Employee();
        e.input();
        int cnt = 0;
        for (Employee item : empList) {
            if (e.id.equals(item.id)) {
                cnt++;
            }
        }
        if (cnt == 0) {
            empList.add(e);
            System.out.println("Add new successfully");
        } else {
            System.out.println("ID is already exist");
        }

    }

    public boolean searchByName() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter name you want to look");
        for (Employee item : empList) {
            if (item.name.equalsIgnoreCase(sc.nextLine().trim())) {
                return true;
            }
        }
        return false;
    }

    public void display() {
        if (empList.isEmpty()) {
            System.out.println("Ko co nhan vien trong HT");
            return;
        }
        System.out.println(">>>> Employee list <<<<");
        empList.forEach(item -> System.out.printf("id: %s, name: %s, address: %s, salary: %d, joined years: %d\n", item.id,item.name,item.address,item.salary,item.joinedYear));
    }

    public void display(int years) {
        if (empList.isEmpty()) {
            System.out.println("Ko co nhan vien trong HT");
            return;
        }

        Employee[] emps = empList.stream().filter((Employee item) -> (2020 - item.joinedYear) > years).toArray(Employee[]::new);
        System.out.println(">>>> Employee list <<<<");
        for (int i = 0; i < emps.length; i++) {
            System.out.println(emps[i]);
        }
    }

    //write file to NV.txt
    String fname = "NV.txt";

    public void writeFileText() {
        if (empList.isEmpty()) {
            System.out.println("Ko co nhan vien trong HT");
            return;
        }

        try {
            //1. open outputstream
            PrintStream ps = new PrintStream(fname);
            //2. ghi toan bo du lieu trong danh sach vo output stream
            empList.forEach(ps::println);
            //ds.forEach(item->ps.println(item));
            //3. close
            ps.close();
        } catch (Exception ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
    }

    //read file from NV.txt
    public void readFileText() {
        File f = new File(fname);
        if (f.exists() == false) {
            return;
        }

        empList = new HashSet<>();

        try {
            BufferedReader br = new BufferedReader(new FileReader(fname));

            String line = null;
            while (br.ready()) {
                line = br.readLine();// doc 1 dong vb - > line
                String[] items = line.split(",");
                if (items.length == 5) {
                    Employee e = new Employee();
                    e.id = items[0].trim();
                    e.name = items[1].trim();
                    e.address = items[2].trim();
                    e.salary = Integer.parseInt(items[3].trim());
                    e.joinedYear = Integer.parseInt(items[4].trim());

                    empList.add(e);
                }
            }
            br.close();
        } catch (Exception ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
    }

    public void menu() {
        Scanner sc = new Scanner(System.in);
        String op = "";
        while (true) {
            System.out.println("==MENU==");
            System.out.println("1. Add a new employee");
            System.out.println("2. Search emp by name in the system");
            System.out.println("3. Show all");
            System.out.println("4. Show all emp have worked years more than input year");
            System.out.println("5. Save & Exit");
            System.out.print("Please choose a number [1-5]: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    addEmp();
                    break;
                case "2":
                    searchByName();
                    break;
                case "3":
                    display();
                    break;
                case "4":
                    System.out.println("Enter number of year");
                    display(Integer.parseInt(sc.nextLine().trim()));
                    break;
                case "5":
                    writeFileText();
                    return;
                default:
                    System.out.println("Invalid option");
             
            }
        }
    }

}
