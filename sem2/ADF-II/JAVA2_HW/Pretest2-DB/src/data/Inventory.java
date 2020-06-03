package data;

import java.sql.*;
import java.util.*;

public class Inventory {

    public static void main(String[] args) {
        Inventory m = new Inventory();
        m.menu();
    }

    public static ArrayList<Product> Display() {
        ArrayList<Product> ds = new ArrayList<>();

        Connection cn = MyLib.getCN();
        try {
            //tao doi tuong statement chua link select sql
            Statement st = cn.createStatement();
            //cho thuc hien link select
            String sql = "SELECT * FROM tbProduct";
            ResultSet rs = st.executeQuery(sql);

            //viet vong lap
            while (rs.next()) {
                //trong moi dong, doc tung cot - va tao ra 1 doi tuong Batch -> dua vao ds
                Product b = new Product();
                b.id = rs.getInt(1); // rs.getString(1)
                b.name = rs.getString(2); //rs.getString(2)
                b.price = rs.getInt(3); //rs.getInt(3)
                b.qoh = rs.getInt(4);
                //>>>>>> dua vao ds <<<<<<
                ds.add(b);
            }

            //dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
        return ds;
    }

    public static int Add(Product b) {
        int r = 0;
        //1. mo ket noi
        Connection cn = MyLib.getCN();

        //2. tao doi tuong PrepareStatement chua cau lenh insert sql
        String sql = "insert tbProduct values(?,?,?)";

        try {
            PreparedStatement st = cn.prepareStatement(sql);

            //3. dien gia tri cac thuoc tinh trong doi tuong lop hoc cho cac tham so?
            st.setString(1, b.name);
            st.setInt(2, b.price);
            st.setInt(3, b.qoh);

            //4.thi hanh len
            r = st.executeUpdate();

            //5. dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: " + ex.getMessage());
        }

        return r;
    }

    public static ArrayList<Product> Search(String des) {
        ArrayList<Product> ds = new ArrayList<>();

        Connection cn = MyLib.getCN();
        try {
            //tao doi tuong statement chua link select sql
            Statement st = cn.createStatement();
            //cho thuc hien link select
            String sql = "SELECT * FROM tbProduct where name = " + des;
            ResultSet rs = st.executeQuery(sql);

            //viet vong lap
            while (rs.next()) {
                //trong moi dong, doc tung cot - va tao ra 1 doi tuong Batch -> dua vao ds
                Product b = new Product();
                b.id = rs.getInt(1);
                b.name = rs.getString(2);
                b.price = rs.getInt(3);
                b.qoh = rs.getInt(4);
                //>>>>>> dua vao ds <<<<<<
                ds.add(b);
            }

            //dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
        return ds;
    }

    void menu() {
        Scanner sc = new Scanner(System.in);
        String op = "";
        while (true) {
            System.out.println("==MENU==");
            System.out.println("1. Xem danh sach sp");
            System.out.println("2. Tìm sản phẩm theo tên");
            System.out.println("3. Thêm 1 sản phẩm mới");
            System.out.println("4. Thoát");
            System.out.print("Choose a number: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    Display().forEach(System.out::println);
                    break;
                case "2":
                    System.out.print("Nhap ten san pham muon tim: ");
                    Search(sc.nextLine().trim()).forEach(System.out::println);
                    break;
                case "3":
                    Product p = new Product();
                    p.input();
                    if (Add(p) == 0) {
                        System.out.println("That bai");
                    } else {
                        System.out.println("Thanh cong");
                    }
                    break;
                case "4":
                    return;
                default:
                    System.out.println("Invalid choice");
            }
        }
    }

}
