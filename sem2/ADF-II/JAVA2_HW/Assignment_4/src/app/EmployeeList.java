package app;

import java.util.HashSet;
import java.util.Scanner;

public class EmployeeList {

    public static void main(String[] args) {
        // TODO code application logic here
    }

    HashSet<Employee> empList;

    public EmployeeList() {
        empList = new HashSet<>();

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
        for(Employee item : empList){
            if(item.name.equalsIgnoreCase(sc.nextLine().trim())){
                return true;
            }
        }
        return false;
    }
    
    public void display(){
        if(empList.isEmpty()){
            System.out.println("Ko co nhan vien trong HT");
            return;
        }
        empList.forEach(item -> System.out.printf("%s", item.name));
    }
    
    public void display(int years){
        if(empList.isEmpty()){
            System.out.println("Ko co nhan vien trong HT");
            return;
        }
        
        Employee[] emps = empList.stream().filter((Employee item) ->  item.joinedYear > years).toArray(Employee[]::new);
        
        for (int i = 0; i < emps.length; i++) {
            System.out.println(emps[i]);
        }
    }
    
    public void writeFileText(){
        
    }
    
    public void readFileText(){
        
    }
    
    public void menu(){
        Scanner 
    }
    
    

}
