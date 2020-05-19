/*
 * Test co kiem tra loi NewException
 */
package demo;

import java.util.Scanner;

public class Test2 {

    public static void main(String[] args) {
        int diem;
        java.util.Scanner scanner = new Scanner(System.in);

        while (true) {
            try {
                System.out.print("Nhap diem thi [0-100]: ");
                diem = Integer.parseInt(scanner.nextLine().trim());
                if (diem >= 0 && diem <= 100) {
                    break;
                }
                throw new NewException("Diem thi phai >=0 và <= 100");
            } catch (Exception e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }
        String xepLoai = "";
        System.out.print("Phân loại: ");
        if (diem >= 90) {
            xepLoai = "A";
        } else if (diem >= 70) {
            xepLoai = "B";
        } else if (diem >= 50) {
            xepLoai = "C";
        } else {
            xepLoai = "D";
        }

        System.out.printf("\nDiem KQ = %d, => Xep loai: %s\n", diem, xepLoai);
    }

}
