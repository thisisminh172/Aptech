/*
 * Day la 1 Thread in ra 1 thong bao 20 lan
 */
package demo;

import java.util.logging.Level;
import java.util.logging.Logger;


public class One extends Thread {

    @Override
    public void run() {
        //day la phuong thuc cai dat nhiem vu cua 1 thread phai lam
        for (int i = 0; i < 20; i++) {
            try {
                System.out.println("\t I am Number One !");
                
                Thread.sleep(500);
            } catch (InterruptedException ex) {
                System.out.println("Loi: " +ex.getMessage());
            }
        }
    }
    
    
    
    
}
