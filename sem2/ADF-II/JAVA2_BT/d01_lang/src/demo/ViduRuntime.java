/*
 * Su dung lop runtime de mo chuong trinh notepad
 */
package demo;

import java.io.IOException;



public class ViduRuntime {

   
    public static void main(String[] args) {
        //lay doi tuong tham chieu cua lop runtime
        Runtime r = Runtime.getRuntime();
        String fname = "E:\\thuJAVA.txt";
        try {
            //mo chuong trinh nodepad bang doi tuong r
            r.exec("notepad " + fname);
        } catch (IOException ex) {
            System.out.println("Loi: "+ ex.getMessage());
        }
        
    }
    
}
