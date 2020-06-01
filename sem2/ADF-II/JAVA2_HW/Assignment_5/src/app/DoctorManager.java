package app;

import java.io.IOException;
import java.io.PrintStream;
import java.util.List;
import java.util.Scanner;
import java.util.TreeMap;

public class DoctorManager {

    public static void main(String[] args) {
        DoctorManager m = new DoctorManager();
        m.menu();
    }

    TreeMap<String, Doctor> doctorList;
    String fname = "doctor.txt";

    public DoctorManager() {
        doctorList = new TreeMap<>();
        readFile();
    }

    public void add() {
        Scanner sc = new Scanner(System.in);
        Doctor d = new Doctor();
        //nhap id
        while (true) {
            System.out.print("Enter doctor id: ");
            d.id = sc.nextLine().trim();
            if (doctorList.containsKey(d.id)) {
                System.out.println("The id is already exist");
                return;
            }
            break;
        }

        while (true) {
            System.out.print("Enter doctor name: ");
            d.name = sc.nextLine().trim();
            if (d.name.length() != 0) {
                break;
            }
            System.out.println("Doctor name can not be empty");
        }

        while (true) {
            System.out.print("Enter specialization: ");
            d.specialization = sc.nextLine().trim();
            if (d.specialization.length() != 0) {
                break;
            }
            System.out.println("Specialization can not be empty");
        }

        while (true) {
            System.out.print("Enter available hours[8-18]: ");
            try {
                d.availHours = Integer.parseInt(sc.nextLine().trim());
                if (d.availHours >= 8 && d.availHours <= 18) {
                    break;
                }
                System.out.println("Available hours must be between 8 to 18");
            } catch (NumberFormatException e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }

//        if(java.util.regex.Pattern.matches("\\d{4}",maLop)==true){
//                break;
//            }
        doctorList.put(d.id, d);
    }

    public void display() {
        if (doctorList.isEmpty()) {
            System.out.println("System is empty");
            return;
        }

        doctorList.values().forEach((item) -> {
            System.out.println(item);
        });
    }

    public void display(String id) {
        if (doctorList.isEmpty()) {
            System.out.println("System is empty");
            return;
        }

        int cnt = 0;

        if (doctorList.containsKey(id)) {
            System.out.println(doctorList.get(id));
            cnt++;
        }

        if (cnt == 0) {
            System.out.println("Can't find any doctor have id: " + id);
        }

    }

    public void readFile() {
        //doc noi dung cua tap tin [embothuoc.txt] xuat len man hinh
        java.nio.file.Path p = java.nio.file.Paths.get(fname);

        try {
            List<String> docList = java.nio.file.Files.readAllLines(p);//.forEach(System.out::println);
            for (String item : docList) {
                String[] eachDoctorLineInfo = item.split(",");
                Doctor d = new Doctor();
                d.id = eachDoctorLineInfo[0];
                d.name = eachDoctorLineInfo[1];
                d.specialization = eachDoctorLineInfo[2];
                d.availHours = Integer.parseInt(eachDoctorLineInfo[3]);
                doctorList.put(d.id, d);
            }
        } catch (IOException ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
    }

    public void saveFile() {
        if (doctorList.isEmpty()) {
            System.out.println("Loi HT chua co du lieu");
            return;
        }

        try {
            //1. open outputstream
            PrintStream ps = new PrintStream(fname);
            //2. ghi toan bo du lieu trong danh sach vo output stream
            for (Doctor item : doctorList.values()) {
                ps.println(item);
            }
            //ds.forEach(item->ps.println(item));
            //3. close
            ps.close();
        } catch (Exception ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
    }

    void menu() {
        Scanner sc = new Scanner(System.in);
        String op = null;
        while (true) {
            System.out.println("===MENU===");
            System.out.println("1. Add a new doctor");
            System.out.println("2. Display doctor list");
            System.out.println("3. Search doctor by id");
            System.out.println("4. Save and exit");
            System.out.print("Choose your option: ");
            op = sc.nextLine().trim();
            switch(op){
                case "1":
                    add();
                    break;
                case "2":
                    display();
                    break;
                case "3":
                    System.out.print("Enter doctor id you want to search: ");
                    display(sc.nextLine().trim());
                    break;
                case "4":
                    saveFile();
                    return;
                default: 
                    System.out.println(">>> invalid choice <<<");  
                    
            }
        }

    }

}
