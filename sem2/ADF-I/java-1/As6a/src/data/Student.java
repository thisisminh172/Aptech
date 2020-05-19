package data;

import java.util.Scanner;

public class Student {

    public String id, name;
    boolean gender;
    int theory, practice;
    public int average;

    public Student() {
        input();
    }

    public Student(String id, String name, boolean gender, int theory, int practice) {
        this.id = id;
        this.name = name;
        this.gender = gender;
        this.theory = theory;
        this.practice = practice;
        this.average = (theory+practice)/2;
    }
    
    

    //function check theory and practice is in the range[0-100]
    private boolean check(int n) {
        if (n >= 0 && n <= 100) {
            return true;
        }
        return false;
    }

    //function return String male for female
    private String gender(boolean gd) {
        if (gd) {
            return "Male";
        }
        return "Female";
    }

    private void input() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter student's id: ");
        id = scanner.nextLine();
        System.out.print("Enter student's name: ");
        name = scanner.nextLine();
        System.out.print("Enter student's gender: ");
        String s = scanner.nextLine();
        Scanner gt = new Scanner(s);
        while(gt.hasNext()){
            if(gt.hasNextBoolean()){
                gender = gt.nextBoolean();
            }else{
                gender = false;
            }
        }
        gt.close();
        //gender = scanner.nextBoolean();
        System.out.print("Enter student's theory: ");
        theory = Integer.parseInt(scanner.nextLine());
        System.out.print("Enter student's practice: ");
        practice = Integer.parseInt(scanner.nextLine());
        average = (theory + practice)/2;
    }

    public void print() {
        System.out.println("Student's ID: " + id);
        System.out.println("Student's name: " + name);
        System.out.println("Student's gender: " + gender(gender));
        System.out.println("Theory: " + theory);
        System.out.println("Practice: " + practice);
    }
    
    @Override
    public String toString(){
        return String.format("%s, %s, %s, %d, %d, %d", id, name, gender(gender),theory,practice,(theory+practice)/2);
    }

}
