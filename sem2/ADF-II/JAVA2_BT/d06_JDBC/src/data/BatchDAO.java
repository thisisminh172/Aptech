/*
lop thuc hien cac chuc nang CRUD(create,read(select),update,delete) tren bang tbBatch
 */
package data;

import java.sql.*;
import java.util.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class BatchDAO {

    //ham thuc hien chuc nang truy van du lieu trong bang [tbBatch] ve tra ve 1 ArrayList
    public static ArrayList<Batch> getList() {
        ArrayList<Batch> ds = new ArrayList<>();
        
        Connection cn = MyLib.getCN();
        try {
            //tao doi tuong statement chua link select sql
            Statement st = cn.createStatement();
            //cho thuc hien link select
            String sql = "SELECT * FROM tbBatch";
            ResultSet rs = st.executeQuery(sql);
            
            //viet vong lap
            while(rs.next()){
                //trong moi dong, doc tung cot - va tao ra 1 doi tuong Batch -> dua vao ds
                Batch b = new Batch();
                b.maLop = rs.getString("batchno"); // rs.getString(1)
                b.chuongTrinh = rs.getString("description"); //rs.getString(2)
                b.hocPhi = rs.getInt("fee"); //rs.getInt(3)
                
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
    
    //ham them 1 lop hoc moi vo bang [tbBatch], tra ve 1 so nguyen
    public static int insert(Batch b){
        int r = 0;
        //1. mo ket noi
        Connection cn = MyLib.getCN();
        
        //2. tao doi tuong PrepareStatement chua cau lenh insert sql
        String sql = "insert tbBatch values(?,?,?)";
        
        try {
            PreparedStatement st = cn.prepareStatement(sql);
            
            //3. dien gia tri cac thuoc tinh trong doi tuong lop hoc cho cac tham so?
            st.setString(1, b.maLop);
            st.setString(2, b.chuongTrinh);
            st.setInt(3, b.hocPhi);
            
            //4.thi hanh len
            r = st.executeUpdate();
            
            //5. dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
        return r;
    }
    
    //xoa lop hoc theo ma so
    public static int delete(String batchNo){
        int r = 0;
        //1. mo ket noi
        Connection cn = MyLib.getCN();
        
        //2. tao doi tuong PrepareStatement chua cau lenh delete sql
        String sql = "delete from tbBatch where batchno = ?";
        try {
            PreparedStatement st = cn.prepareStatement(sql);
            
            //3. truyen gia tri cua parameter cho tham so ?
            st.setString(1,batchNo);
            
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
