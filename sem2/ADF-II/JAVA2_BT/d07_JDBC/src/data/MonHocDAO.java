
package data;
import java.sql.*;
import java.util.*;


public class MonHocDAO {
     public static ArrayList<MonHoc> getList() {
        ArrayList<MonHoc> ds = new ArrayList<>();
        
        Connection cn = MyLib.getCN();
        try {
            //tao doi tuong statement chua link select sql
            Statement st = cn.createStatement();
            //cho thuc hien link select
            String sql = "SELECT * FROM tb_MonHoc";
            ResultSet rs = st.executeQuery(sql);
            
            //viet vong lap
            while(rs.next()){
                //trong moi dong, doc tung cot - va tao ra 1 doi tuong MonHoc -> dua vao ds
                MonHoc b = new MonHoc();
                b.ma = rs.getInt(1); // rs.getString(1)
                b.tenNgan = rs.getString(2); //rs.getString(2)
                b.tenDai = rs.getString(3);
                b.soTiet = rs.getInt(4); //rs.getInt(3)
                
                //>>>>>> dua vao ds <<<<<<
                ds.add(b);
            }
            
            //dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        return ds;
    }
     
     public static int insert(MonHoc b){
        int r = 0;
        //1. mo ket noi
        Connection cn = MyLib.getCN();
        
        //2. tao doi tuong PrepareStatement chua cau lenh insert sql
        String sql = "insert tb_MonHoc values(?,?,?)";
        
        try {
            PreparedStatement st = cn.prepareStatement(sql);
            
            //3. dien gia tri cac thuoc tinh trong doi tuong lop hoc cho cac tham so?
            st.setString(1, b.tenNgan);
            st.setString(2, b.tenDai);
            st.setInt(3, b.soTiet);
            
            //4.thi hanh len
            r = st.executeUpdate();
            
            //5. dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
        return r;
    }
    
}
