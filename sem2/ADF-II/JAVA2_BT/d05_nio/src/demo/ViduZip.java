/*
 * Nen 1 tap tin van ban. 
 */
package demo;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.util.zip.DeflaterOutputStream;

public class ViduZip {

    public static void main(String[] args) {
        ViduZip vd = new ViduZip();
        vd.zipFile();
    }

    String fname1 = "/home/minhl/Aptech/sem2/Aptech/sem2/ADF-II/JAVA2_BT/embothuoc.txt";
    String fname2 = "/home/minhl/Aptech/sem2/Aptech/sem2/ADF-II/JAVA2_BT/embothuoc.FLT";

    void zipFile() {
        try{
            java.io.FileInputStream fis = new FileInputStream(fname1);
            java.io.FileOutputStream fos = new FileOutputStream(fname2);
            java.util.zip.DeflaterOutputStream dos = new DeflaterOutputStream(fos);
            
            int b;
            while((b = fis.read()) != -1){
                dos.write(b);
            }
            
            dos.close();
            fis.close();
            fos.close();
        }catch(Exception ex){
            System.out.println("Loi: "+ex.getMessage());
        }
    }

}
