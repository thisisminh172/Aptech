/*
Lop mo ta cau truc cua mot lop hoc (cau truc tuong tu bang tbBatch trong db sem2_demo)
 */
package data;

import java.util.Scanner;


public class Batch {
    //batchno, description, fee
    public String maLop,chuongTrinh;
    public int hocPhi;
    
    public void input(){
        Scanner sc = new Scanner(System.in);
        //nhap ma lop, 4 ky so bat ky
        while(true){
            System.out.print("Nhap ma lop (4 ky so): ");
            maLop = sc.nextLine().trim();
            
            if(java.util.regex.Pattern.matches("\\d{4}",maLop)==true){
                break;
            }
            System.out.println(">> ma lop ko hop le. vui long nhap lai");
        }
        
        //nhap ten lop hoc toi da 20 char
        while(true){
            System.out.print("nhap ten chuong trinh: ");
            chuongTrinh = sc.nextLine().trim();
            if(chuongTrinh.length()>=3 && chuongTrinh.length()<=20){
                break;
            }
            System.out.println(">> chuong trinh ko hop le. vui long nhap lai");
        }
        
        //hoc phi
        while(true){
            try{
                System.out.print("Nhap hoc phi[100-10000]: ");
                hocPhi = Integer.parseInt(sc.nextLine().trim());
                if(hocPhi>=100&&hocPhi<=10000){
                    break;
                }
            }catch(Exception e){
                System.out.println("Loi: "+e.getMessage());
            }
        }
    }

    @Override
    public String toString() {
        return String.format("%-5s , %-20s, %5d", maLop,chuongTrinh,hocPhi);
    }
    
    
}
