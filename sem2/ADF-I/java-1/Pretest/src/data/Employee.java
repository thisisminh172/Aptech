
package data;


public class Employee extends Person {
    public int salary, workedDays;
    public String position;

    public Employee(String id, String name, int yob,int salary,int workedDays,String position) {
        super(id, name, yob);
        this.salary = salary;
        this.workedDays = workedDays;
        this.position = position;
    }
    
    
    
}
