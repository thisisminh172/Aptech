/*
 * kiem thu cac chuc năng CRUD cua lop BatchDAO
 */
package app;

import data.*;
import java.util.*;

public class TestBATCH {

    public static void main(String[] args) {
        TestBATCH m = new TestBATCH();
        m.menu();
    }

    void menu() {
        Scanner sc = new Scanner(System.in);
        String op = null;
        while (true) {
            System.out.println("\n MENU");
            System.out.println("**********");
            System.out.println("1. Xem danh sach");
            System.out.println("2. Them moi");
            System.out.println("3. Xoa");
            System.out.println("4. Thoat");
            System.out.print("Chọn chức năng [1-4]: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    //in danh sach lop hoc
                    ArrayList<Batch> ds = BatchDAO.getList();
                    System.out.println("danh sach lop hoc: ");
                    ds.forEach(System.out::println);
                    break;
                case "2":
                    //them 1 lop hoc moi
                    Batch lopMoi = new Batch();
                    lopMoi.input();
                    if (BatchDAO.insert(lopMoi) > 0) {
                        System.out.println("them lop Thanh cong");
                    } else {
                        System.out.println("That bai");
                    }
                    break;
                case "3":
                    System.out.print("Nhap ma lop muon xoa: ");
                    String tb = BatchDAO.delete(sc.nextLine().trim())>0?"Thanh cong":"That bai";
                    System.out.println(tb);
                    break;
                case "4":
                    return;
                default:
                    System.out.println("invalid");
            }
        }
    }

}
