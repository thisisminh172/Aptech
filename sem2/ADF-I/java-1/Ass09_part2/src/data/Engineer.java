package data;

import java.util.Scanner;

public class Engineer extends Employee implements ISalary, ITaxable {

    private int level;

    public int getLevel() {
        return level;
    }

    public void setLevel(int level) {
        this.level = level;
    }
    
    public Engineer() {
    }

    public Engineer(int level, String id, String name, int workedDays, int salary) {
        super(id, name, workedDays, salary);
        this.level = level;
    }

    protected void accept() {
        super.accept();
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.print("Enter your level: ");
            level = Integer.parseInt(scanner.nextLine().trim());
            if (level >= 1 && level <= 4) {
                break;
            }
            System.out.println("Invalid level number");
        }
    }

    @Override
    public void printInfo() {
        System.out.print("\nid: "+getId());
        System.out.print(", name: "+getName());
        System.out.print(", worked days: "+getWorkedDays());
        System.out.print(", salary: "+getSalary());
        System.out.print(", level: "+getLevel()+"\n");
    }

    @Override
    public float getAllowance() {
        switch (level) {
            case 1:
                return 400;
            case 2:
                return 600;
            case 3:
                return 1000;
            case 4:
                return 2000;
            default:
                return 0;
        }
    }

    @Override
    public float getIncome() {
        float monthly_sal = getSalary() * getWorkedDays() / 24 + getAllowance();
        return monthly_sal-getTax()+getAllowance();
    }

    @Override
    public float getTax() {
        float monthly_sal = getSalary() * getWorkedDays() / 24 + getAllowance();
        return monthly_sal * INCOME_TAX_PERC;
    }



    @Override
    public String toString() {
        return "Engineer{"+"id="+getId()+", name="+getName()+", worked days="+getWorkedDays()+", salary="+getSalary() + ", level=" + level +", payroll="+getIncome()+ '}';
    }
    
    
    

}
