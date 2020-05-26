/*
 Vi du giai nen tap tin FLT - TXT
 */
package demo;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.zip.InflaterOutputStream;

public class ViduUnzip {

    public static void main(String[] args) {
        // TODO code application logic here
        ViduUnzip vd = new ViduUnzip();
        vd.unzipFile();
    }

    String fname1 = "/home/minhl/Aptech/sem2/Aptech/sem2/ADF-II/JAVA2_BT/embothuoc.FLT";
    String fname2 = "/home/minhl/Aptech/sem2/Aptech/sem2/ADF-II/JAVA2_BT/embothuoc-unzip.txt";

    void unzipFile() {
        try {
            java.io.FileInputStream fis = new FileInputStream(fname1);
            java.io.FileOutputStream fos = new FileOutputStream(fname2);
            java.util.zip.InflaterOutputStream ios = new InflaterOutputStream(fos);
            
            int b;
            while((b=fis.read())!= -1){
                ios.write(b);
            }
            fis.close();
            fos.close();
            ios.close();
            System.out.println("FINISHED");
            //khi chay chuong trinh khoi dong sublime
            Runtime r = Runtime.getRuntime();
            r.exec("subl "+fname2);
        } catch (Exception ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
    }

}
