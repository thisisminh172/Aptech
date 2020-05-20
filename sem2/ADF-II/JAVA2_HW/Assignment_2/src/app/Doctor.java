package app;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Doctor {

    public String id, name, level;
    public int exp_years;

    public Doctor() {
    }

    public Doctor(String id, String name, String level, int exp_years) {
        this.id = id;
        this.name = name;
        this.level = level;
        this.exp_years = exp_years;
    }

    public void input() {
        Scanner sc = new Scanner(System.in);
        String idPat = "[D]\\d{2,4}";
        String namePat = "[a-z A-Z]{2,}";
        String levelPat = "(level 1|level 2|level 3)";
        Pattern p;
        Matcher m;
        while (true) {
            System.out.print("Enter doctor's id: ");
            id = sc.nextLine().trim();
            p = Pattern.compile(idPat);
            m = p.matcher(id);
            if (m.matches()) {
                break;
            }
            System.out.println("ID must be Dxx[xx] - must have 2 to 4 numbers");
        }
        while (true) {
            System.out.print("Enter doctor's name: ");
            name = sc.nextLine().trim();
            p = Pattern.compile(namePat);
            m = p.matcher(name);
            if (m.matches()) {
                break;
            }
            System.out.println("Name must have at least 2 characters");
        }
        while (true) {
            System.out.print("Enter level: ");
            level = sc.nextLine().trim();
            p = Pattern.compile(levelPat, Pattern.CASE_INSENSITIVE);
            m = p.matcher(level);
            if (m.matches()) {
                break;
            }
            System.out.println("level must be level 1 |level 2 | level 3");
        }
        while (true) {
            try{
                System.out.print("Enter number of experiment years: ");
            exp_years = Integer.parseInt(sc.nextLine().trim());
            if (exp_years >= 0 && exp_years <= 60) {
                break;
            }
            System.out.println("Number of year must be in 0-60");
            }catch(Exception e){
                System.out.println("Error: "+e.getMessage());
            }
        }
    }

    @Override
    public String toString() {
        return "Doctor{" + "id=" + id + ", name=" + name + ", level=" + level + ", exp_years=" + exp_years + '}';
    }
    
}
