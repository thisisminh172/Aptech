/*
 * chay 2 threads
 */
package demo;

import java.util.logging.Level;
import java.util.logging.Logger;

public class ViDuThread {

    public static void main(String[] args) {
        System.out.println("so luong thread: " + Thread.activeCount());
        System.out.println("Ten thread hien tai: " + Thread.currentThread().getName());

        //thao tac thread thu 2 trong ct
        Thread t2 = new One();

        //thao tac thread thu 3 trong ct
        Thread t3 = new Thread(new Two());

        //tao ra thread thu 4
        Runnable r = () -> {
            for (int i = 0; i < 50; i++) {
                try {
                    System.out.printf("%d I am Deamon Thread\n", i + 1);
                    Thread.sleep(250);
                } catch (InterruptedException ex) {
                    System.out.println("Loi: " + ex.getMessage());
                    
                }
            }
        };
        
        Thread t4 = new Thread(r);
        t4.setDaemon(true);
        //cho thread t2 va t3 chay
        t2.start();
        t3.start();
        t4.start();

        //Cach 1
        //while(t2.isAlive() || t3.isAlive());
        try {

            //cach 2
            t2.join();//yeu cau phai thuc hien, tham gia vao tien do cua main cho nen nhung cau lenh cua main phai doi no
            t3.join();
            //t4.join();
        } catch (InterruptedException ex) {
            System.out.println("Loi: " + ex.getMessage());
        }

        //in thong bao ket thuc chuong trinh
        System.out.println("\n *** KET THUC CHUONG TRINH ***");
    }

}
