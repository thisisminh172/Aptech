package model;

import java.util.Scanner;

public class Project {

    public int id, value;
    public String projectName, startDate;
    public boolean completed;

    public Project() {
    }

    public Project(int id, int value, String projectName, String startDate, boolean completed) {
        this.id = id;
        this.value = value;
        this.projectName = projectName;
        this.startDate = startDate;
        this.completed = completed;
    }

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Nhap thong tin san pham");
        while (true) {
            System.out.print("Nhap ten project: ");
            projectName = sc.nextLine().trim();
            if (projectName.length() >= 2 && projectName.length() <= 30) {
                break;
            }
            System.out.println("project name phai chua tu 2-30 ky tu");
        }
        String startDatePat = "\\d{4}-\\d{2}-\\d{2}";
        while (true) {
            System.out.print("Enter start date[yyyy-mm-dd]: ");
            startDate = sc.nextLine().trim();
            if (java.util.regex.Pattern.matches(startDatePat, startDate)) {
                break;
            }
            System.out.println("Start date format yyyy-mm-dd");
        }
        while (true) {
            try {
                System.out.print("Nhap value: ");
                value = Integer.parseInt(sc.nextLine().trim());
                if (value >= 0) {
                    break;
                }
                System.out.println("Value can not be negative");
            } catch (Exception ex) {
                System.out.println("Loi: " + ex.getMessage());
            }
        }

        while (true) {
            try {
                System.out.print("Is completed? true or false: ");
                completed = sc.nextBoolean();
                if(completed == true || completed == false){
                    break;
                }
                System.out.println("must be true or false");
            }catch(Exception ex){
                System.out.println("Loi: "+ex.getMessage());
            }
        }
    }

    @Override
    public String toString() {
        return String.format("%d,%s,%s,%d,%b", id,projectName,startDate,value,completed);
    }
    
    
}
