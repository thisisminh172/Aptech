package app;

import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Employee {

    public String id, name, address;
    public int salary, joinedYear;

    public Employee() {
    }

    public Employee(String id, String name, String address, int salary, int joinedYear) {
        this.id = id;
        this.name = name;
        this.address = address;
        this.salary = salary;
        this.joinedYear = joinedYear;
    }

    @Override
    public String toString() {
        return String.format("%s,%s,%s,%d,%d", id, name, address, salary, joinedYear);
    }

    public void input() {
        Scanner sc = new Scanner(System.in);
        String idPat = "(EM)\\d{4}";
        Pattern p = null;
        Matcher m = null;

        while (true) {
            System.out.print("Enter id number: ");
            id = sc.nextLine().trim();
            p = Pattern.compile(idPat);
            m = p.matcher(id);
            if (m.matches()) {
                break;
            }
            System.out.println("id must contain: EMxxxx");
        }

        while (true) {
            System.out.print("Enter name: ");
            name = sc.nextLine().trim();
            if (!name.isEmpty()) {
                break;
            }
            System.out.println("Name can't be empty");
        }

        while (true) {
            System.out.print("Enter address: ");
            address = sc.nextLine().trim();
            if (!address.isEmpty()) {
                break;
            }
            System.out.println("Address can't be empty");
        }

        while (true) {
            try {
                System.out.print("Enter salary[100-10000]: ");
                salary = Integer.parseInt(sc.nextLine().trim());
                if(salary>=100 && salary <=10000){
                    break;
                }
                throw new Exception("The salary must be between 100-10000");
            } catch (Exception ex) {
                System.out.println("Error: "+ex.getMessage());
            }
        }
        
        while (true) {
            try {
                System.out.print("Enter joined year[1980-2016]: ");
                joinedYear = Integer.parseInt(sc.nextLine().trim());
                if(joinedYear>=1980 && joinedYear <=2016){
                    break;
                }
                throw new Exception("The joined Year must be between 1980-2016");
            } catch (Exception ex) {
                System.out.println("Error: "+ex.getMessage());
            }
        }
    }

}
