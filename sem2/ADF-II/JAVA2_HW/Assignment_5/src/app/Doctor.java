/*
class doctor
1. Tạo class Doctor, hiện thực giao diện Serializable (implements Serializable) bao gồm :
a. Các fields dữ liệu:
i. String id, name, specialization
ii. int availHours
b. Các contructors để khởi tạo giá trị ban đầu cho các field dữ liệu.
c. Override method public String toString() 
 */
package app;

import java.io.Serializable;
import java.util.Scanner;

public class Doctor implements Serializable {

    public String id, name, specialization;
    public int availHours;

    public Doctor() {
    }
    
    

    @Override
    public String toString() {
        return String.format("%s,%s,%s,%d", id,name,specialization,availHours);
    }

    
}
