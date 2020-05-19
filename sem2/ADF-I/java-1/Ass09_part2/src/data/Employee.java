package data;

import java.util.Scanner;

public abstract class Employee {

    private String id, name;
    private int workedDays, salary;

    public Employee() {
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    

    public int getWorkedDays() {
        return workedDays;
    }

    public void setWorkedDays(int workedDays) {
        this.workedDays = workedDays;
    }

    public int getSalary() {
        return salary;
    }

    public void setSalary(int salary) {
        this.salary = salary;
    }
    
    

    public Employee(String id, String name, int workedDays, int salary) {
        this.id = id;
        this.name = name;
        this.workedDays = workedDays;
        this.salary = salary;
    }

    //hàm checkNull nếu có giá trị trả về true
    boolean isNotNull(String s) {
        return s.length() > 0;
    }

    protected void accept() {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.print("Enter your id: ");
            id = scanner.nextLine().trim();
            if (isNotNull(id)) {
                break;
            }
        }
        
        while (true) {
            System.out.print("Enter your name: ");
            name = scanner.nextLine().trim();
            if (isNotNull(name)) {
                break;
            }
        }
        
        while (true) {
            System.out.print("Enter your work days: ");
            workedDays = Integer.parseInt(scanner.nextLine().trim());
            if (workedDays > 0) {
                break;
            }
        }
        
        while (true) {
            System.out.print("Enter your salary: ");
            salary = Integer.parseInt(scanner.nextLine().trim());
            if (salary > 0) {
                break;
            }
        }
    }
    
    public abstract void printInfo();

    @Override
    public String toString() {
        return "Employee{" + "id=" + id + ", name=" + name + ", workedDays=" + workedDays + ", salary=" + salary + '}';
    }
    
}
