package ui;

import data.Apartment;
import java.util.*;

public class ApartmentTest {

    List<Apartment> ds;

    public ApartmentTest() {
        ds = new ArrayList<Apartment>();
    }

    void add() {
        Apartment a = new Apartment();
        if (ds.size() > 0) {
            for (int i = 0; i < ds.size(); i++) {
                if (a.id.equalsIgnoreCase(ds.get(i).id)) {
                    System.out.println("không thêm mới được");
                    return;
                }
            }
        }
        ds.add(a);
    }

    void display() {
        if (ds.size() > 0) {
            for (Apartment item : ds) {
                System.out.println(item);
            }
        } else {
            System.out.println("***********************");
            System.out.println("there is no apartment");
            System.out.println("***********************");
        }

    }

    void display(int area) {
        if (ds.size() > 0) {
            for (int i = 0; i < ds.size(); i++) {
                if (ds.get(i).width * ds.get(i).length > area) {
                    System.out.println(ds.get(i));
                }
            }

        } else {
            System.out.println("***********************");
            System.out.println("there is no apartment");
            System.out.println("***********************");
        }
    }

    void display(boolean isQuare) {
        for (int i = 0; i < ds.size(); i++) {
            if (isQuare && ds.get(i).isSquare()) {
                System.out.println("Hình vuông:");
                System.out.println(ds.get(i));
            } else if(isQuare && !ds.get(i).isSquare()){
                System.out.println("Hình chữ nhật");
                System.out.println(ds.get(i));
            }
        }
    }

    void menu() {
        Scanner scanner = new Scanner(System.in);
        String op = "";
        while (true) {
            System.out.println("===MENU===");
            System.out.println("1. thêm căn hộ vào danh sách");
            System.out.println("2. In danh sách tất cả căn hộ");
            System.out.println("3. In danh sách căn hộ có diện tích m trở lên");
            System.out.println("4. In danh sách căn hộ theo hình vuông hoặc hình chữ nhật");
            System.out.println("5. Thoát");
            System.out.print("Chọn chức năng [1-5]: ");
            op = scanner.nextLine().trim();
            switch (op) {
                case "1":
                    add();
                    break;
                case "2":
                    display();
                    break;
                case "3":
                    System.out.print("Nhập diện tích m: ");
                    int m = Integer.parseInt(scanner.nextLine().trim());
                    display(m);
                    break;
                case "4":
                    System.out.print("Nhập true là hình vuông, false là hình chữ nhật: ");
                    String s = scanner.nextLine();
                    Scanner sc = new Scanner(s);

                    while (sc.hasNext()) {
                        if (sc.hasNextBoolean()) {
                            display(sc.nextBoolean());
                        }
                    }
                    sc.close();
                    break;
                case "5":
                    System.out.println("kết thúc chương trình");
                    return;
                default:
                    System.out.println("Xin nhập đúng chức năng");
                    break;
            }
        }
    }

    public static void main(String[] args) {
        ApartmentTest m = new ApartmentTest();
        m.menu();
    }

}
