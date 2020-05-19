package data;

import java.util.Scanner;

public class Worker extends Employee implements ISalary, ITaxable {

    private int overtime;

    public Worker() {
    }

    public Worker(int overtime, String id, String name, int workedDays, int salary) {
        super(id, name, workedDays, salary);
        this.overtime = overtime;
    }

    @Override
    protected void accept() {
        Scanner scanner = new Scanner(System.in);
        super.accept();
        while (true) {
            System.out.print("Enter the extra days: ");
            overtime = Integer.parseInt(scanner.nextLine().trim());
            if (overtime >= 0) {
                break;
            }
            System.out.println("overtime must be >= 0");
        }

    }

    @Override
    public void printInfo() {
        toString();
        System.out.println("pay slip: "+getIncome());
    }

    @Override
    public float getAllowance() {
        return 0;
    }

    @Override
    public float getIncome() {
        float monthly_sal = getSalary() * (getWorkedDays() + overtime * 2) / 26;
        return monthly_sal - getTax();
    }

    @Override
    public float getTax() {
        float monthly_sal = getSalary() * (getWorkedDays() + overtime * 2) / 26;
        if (monthly_sal < 400) {
            return 0;
        } else {
            return monthly_sal * INCOME_TAX_PERC;
        }
    }

    @Override
    public String toString() {
        return "Worker{"+"id="+getId()+", name="+getName()+", worked days="+getWorkedDays()+", salary="+getSalary() + ", overtime=" + overtime +", payroll="+getIncome()+ '}';
    }

    
    
    

}
