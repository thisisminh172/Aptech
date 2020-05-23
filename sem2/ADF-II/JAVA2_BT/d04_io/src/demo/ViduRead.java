/*
doc 1 tap tin van ban, xuat noi dung ra man hinh

*/
package demo;
import java.io.*;//lam viec voi tap tin du lieu
import java.util.logging.Level;
import java.util.logging.Logger;

public class ViduRead {

   
    public static void main(String[] args) {
        ViduRead p1 = new ViduRead();
        p1.readFileBin();
        System.out.println("\n*********\n");
        p1.readFileChar();
    }
    
    String fname = "E:\\Aptech\\git\\Aptech\\sem2\\ADF-II\\JAVA2_BT\\embothuoc.txt";
    void readFileBin(){
        try {
            //1. tao input stream ket noi voi embothuoc.txt
            java.io.FileInputStream fis = new FileInputStream(fname);
            
            //2. vong  lap doc tung byte du lieu cua tap tin va xuat len man hinh
            int ch;
            while((ch=fis.read())!=-1){
                System.out.printf("%c",ch);
            }
            
            //3. dong stream lai5
            fis.close();
            
        } catch (Exception ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
    }
    
    void readFileChar(){
        try {
            //1. tao ra char stream de noi voi file embothuoc.txt
            java.io.FileReader fr = new FileReader(fname);
            int ch;
            while((ch=fr.read())!=-1){
                System.out.printf("%c",ch);
        }
        } catch (Exception ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
        
    }
    
    
}
