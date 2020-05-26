/*
 * Lop hien thuc vai tro cua 1 thread: in ra 1 thong bao 3 lan

 */
package demo;


public class Two implements Runnable{

    @Override
    public void run() {
         //day la phuong thuc cai dat nhiem vu cua 1 thread phai lam
        for (int i = 0; i < 30; i++) {
            try {
                System.out.println("\t\t I am Number Two !");
                
                Thread.sleep(200);//milis
            } catch (InterruptedException ex) {
                System.out.println("Loi: " +ex.getMessage());
            }
        }
    }
    
}
