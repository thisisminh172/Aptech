package data;

import java.util.ArrayList;

public class EmployeeCatalog {

    ArrayList<Employee> eList;

    public EmployeeCatalog() {
        eList = new ArrayList<Employee>();
    }

    public void addWorker() {
        Worker w = new Worker();
        w.accept();
        int temp = 0;
        for (int i = 0; i < eList.size(); i++) {
            if (w.getId().equalsIgnoreCase(eList.get(i).getId())) {
                temp++;
            }
        }
        if (temp != 0) {
            eList.add(w);
            return;
        }
        System.out.println("id is already used");

    }

    public void addEngineer() {
        Engineer e = new Engineer();
        e.accept();
        int temp = 0;
        for (int i = 0; i < eList.size(); i++) {
            if (e.getId().equalsIgnoreCase(eList.get(i).getId())) {
                temp++;
            }
        }
        if (temp != 0) {
            eList.add(e);
            return;
        }
        System.out.println("id is already used");
        
    }

    public void display() {
        for (Employee em : eList) {
            System.out.println(em);
        }
    }

    public void display(boolean isWorker) {
        if (isWorker) {
            for (Employee em : eList) {
                if (em instanceof Worker) {
                    System.out.println(em);
                }
            }
        } else {
            for (Employee em : eList) {
                if (em instanceof Engineer) {
                    System.out.println(em);
                }
            }
        }
    }

    public void display(String name) {
        if (eList.isEmpty()) {
            System.out.println("No employees");
            return;
        }

        for (int i = 0; i < eList.size(); i++) {
            if (eList.get(i).getName().contains(name)) {
                System.out.println(eList.get(i));
            }
        }
    }

}
