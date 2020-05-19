/*
 * chuong trinh java chưa kiem thu loi NewException
 */
package demo;

import java.util.Scanner;

public class Test {

    public static void main(String[] args) {

        int diem;
        java.util.Scanner scanner = new Scanner(System.in);
        System.out.print("Nhap diem thi [0-100]: ");
        diem = Integer.parseInt(scanner.nextLine().trim());

        String xepLoai="";
        System.out.print("Phân loại: ");
        if (diem >= 90) {
            xepLoai = "A";
        }else if(diem>=70){
            xepLoai = "B";
        }else if(diem>=50){
            xepLoai = "C";
        }else{
            xepLoai = "D";
        }
        
        System.out.printf("\nDiem KQ = %d, => Xep loai: %s\n",diem,xepLoai);
    }

}
