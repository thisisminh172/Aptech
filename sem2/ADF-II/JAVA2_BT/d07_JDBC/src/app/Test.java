
package app;
import data.*;
import java.util.*;

public class Test {

    
    public static void main(String[] args) {
        Test m = new Test();
        m.menu();
    }
    
    public void menu(){
        Scanner sc = new Scanner(System.in);
        String op  = null;
        while(true){
            System.out.println("===MENU===");
            System.out.println("1. Them du lieu moi");
            System.out.println("2. Xem danh sach");
            System.out.println("3. tim ten lop");
            System.out.println("4. Thoat");
            System.out.print(" >> vui long chon chuc nang [1-4]: ");
            op = sc.nextLine().trim();
            switch(op){
                case "1":
                    MonHoc m = new MonHoc();
                    m.input();
                    MonHocDAO.insert(m);
                    break;
                case "2":
                    System.out.println("Danh sach mon hoc: ");
                    MonHocDAO.getList().forEach(System.out::println);
                    
                    break;
                case "3":
                    System.out.print("Nhap ten mon hoc: ");
                    String ten = sc.nextLine().trim();
                    long cnt = MonHocDAO.getList().stream().filter(item -> item.tenNgan.contains(ten)).count();
                    if(cnt==0){
                        System.out.println("Khong tim thay");
                    }else{
                        MonHocDAO.getList().stream().filter(item->item.tenNgan.contains(ten)).forEach(System.out::println);
                    }
                    break;
                case "4":return;
            }
        }
    }
    
}
