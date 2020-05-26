/*
 * Vi du ve new io
 */
package demo;

import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;


public class ViduNIO {

    
    public static void main(String[] args) {
        ViduNIO vd = new ViduNIO();
        vd.readFile();
    }
    
    String fname1 = "/home/minhl/Aptech/sem2/Aptech/sem2/ADF-II/JAVA2_BT/embothuoc.txt";
    
    void readFile(){
        //doc noi dung cua tap tin [embothuoc.txt] xuat len man hinh
        java.nio.file.Path p = java.nio.file.Paths.get(fname1);
        
        try {
            java.nio.file.Files.readAllLines(p).forEach(System.out::println);
        } catch (IOException ex) {
            System.out.println("Loi: "+ ex.getMessage());
        }
    }
    
}
