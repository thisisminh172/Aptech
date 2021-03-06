package app;

import java.util.HashMap;
import java.util.Map;


public class DoctorList {

    Map<String,Doctor> drList = new HashMap<String,Doctor>();

    public void add() {
        Doctor doctor = new Doctor();
        doctor.input();
        int count = 0;
        if (drList.containsKey(doctor.id)) {
            System.out.println(">>> this id is already used <<<");
            count++;
        }
        if (count == 0) {
            drList.put(doctor.id, doctor);
        }
    }

    public void remove(String drID) {
        if(drList.size()==0){
            System.out.println("There is doctor in the list");
            return;
        }
        if(drList.remove(drID)==null){
            System.out.println(">>Khong tim thay bs co ma so "+drID);
        }else{
            System.out.println(">> Da xoa thanh cong <<");
        }
//        if (drList.containsKey(drID)) {
//            drList.remove(drID);
//        }
    }
    
    public void display(){
        for(Doctor item : drList.values()){
            if(item.level.equals("level 2")){
                System.out.println(item);
            }
        }
    }
    
    public void display(String drName){
        for(Object item : drList.values()){
            Doctor dr = (Doctor) item;// ep kieu doctor cho object item
            if(dr.name.toLowerCase().contains(drName)){
                System.out.println(item);
            }
        }
    }

    

}
