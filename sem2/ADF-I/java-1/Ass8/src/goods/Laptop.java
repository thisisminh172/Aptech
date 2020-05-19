
package goods;

import java.util.Scanner;


public class Laptop extends Computer {
    public String webcam;
    public int Qoh;
    
    public Laptop(){
        super();
    }
    public Laptop(String id, String name, int price,String webcam, int Qoh) {
        super(id,name,price);
        this.webcam = webcam;
        this.Qoh = Qoh;
    }
    @Override
    public void accept(){
        Scanner sc = new Scanner(System.in);
        super.accept();
        
        
        //kiem tra nhap webcam,co hoac khong y|n
        while(true){
            System.out.print(" co webcam khong[y|n]: ");
            webcam = sc.nextLine().trim().toLowerCase();
            if(webcam.equals("y")||webcam.equals("n")){
                break;
            }
            System.out.println("Du lieu khong hop le vui long nhap lai !!");
        }
        
        
        while (true) {
            try {
                System.out.print("Nhap so luong ton kho: ");
                Qoh = Integer.parseInt(sc.nextLine().trim());
                if (Qoh > 0) {
                    break;
                }
                System.out.println("so luong khong hop le");
            }catch (Exception e){
                System.out.println("Loi sai: "+e.getMessage());
            }

        }
        
    }
    
    

    @Override
    public void printInfo() {
        System.out.println("Thong tin cua 1 laptop");
        System.out.println("id: "+id);
        System.out.println("name: "+name);
        System.out.println("price: "+price);
        System.out.println("webcam: "+webcam);
        System.out.println("stock: "+ Qoh);
    }

    @Override
    public String toString() {
        return String.format("%s, %s, %d, %s, %d, %d", id, name, price, webcam, Qoh, Qoh*price);
    }
    
    
    
}
