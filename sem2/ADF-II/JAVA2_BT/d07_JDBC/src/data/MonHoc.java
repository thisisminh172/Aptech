package data;

import java.util.Scanner;

public class MonHoc {

    public int ma, soTiet;
    public String tenNgan, tenDai;

    @Override
    public String toString() {
        return String.format("%4d,%-5s,%-3s,%3d", ma, tenNgan, tenDai, soTiet);
    }

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Nhap thong tin cho 1 lop hoc");
        while (true) {
            System.out.print("Nhap ten viet tat: ");
            tenNgan = sc.nextLine().trim();
            if (tenNgan.length() >= 2 && tenNgan.length() <= 5) {
                break;
            }
            System.out.println("ten khong hop le, tu [2-5] ky tu");
        }
        while (true) {
            System.out.print("Nhap ten day du: ");
            tenDai = sc.nextLine().trim();
            if (tenDai.length() >= 2 && tenDai.length() <= 50) {
                break;
            }
            System.out.println("ten khong hop le, tu [2-50] ky tu");
        }

        while (true) {
            try {
                System.out.print("Nhap so tiet hoc: ");
                soTiet = Integer.parseInt(sc.nextLine().trim());
                if (soTiet >= 4 && soTiet <= 60) {
                    break;
                }
                System.out.println("so tiet khong hop le tu 4-60");
            }catch(Exception ex){
                System.out.println("Loi: "+ex.getMessage());
            }
        }
        
        
    }

}
