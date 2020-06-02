
package model;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.*;


public class ProjectDAO {
    public int insert(Project pro){
        int count = 0;
        //1. mo ket noi
        Connection cn = MyLib.getCN();
        
        //2. tao doi tuong PrepareStatement chua cau lenh insert sql
        String sql = "insert tbProject values(?,?,?,?)";
        
        try {
            PreparedStatement st = cn.prepareStatement(sql);
            
            //3. dien gia tri cac thuoc tinh trong doi tuong lop hoc cho cac tham so?
            st.setString(1, pro.projectName);
            st.setString(2, pro.startDate);
            st.setInt(3, pro.value);
            st.setBoolean(4, pro.completed);
            
            //4.thi hanh len
            count = st.executeUpdate();
            
            //5. dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
        return count;
    }
    
    public int delete(String pID){
        int count = 0;
        Connection cn = MyLib.getCN();
        
        String sql = "DELETE FROM tbProject WHERE ID = ?";
        
        try {
            PreparedStatement st = cn.prepareStatement(sql);
            
            
            st.setInt(1, Integer.parseInt(pID));

            count = st.executeUpdate();
            
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
        return count;
    }
    
    public static List<Project> getList(){
        List<Project> pList = new ArrayList<>();
        
        Connection cn = MyLib.getCN();
        try {
            //tao doi tuong statement chua link select sql
            Statement st = cn.createStatement();
            //cho thuc hien link select
            String sql = "SELECT * FROM tbProject";
            ResultSet rs = st.executeQuery(sql);
            
            //viet vong lap
            while(rs.next()){
                //trong moi dong, doc tung cot - va tao ra 1 doi tuong MonHoc -> dua vao ds
                Project p = new Project();
                p.id = rs.getInt(1); // rs.getString(1)
                p.projectName = rs.getString(2); //rs.getString(2)
                p.startDate = rs.getString(3);
                p.value = rs.getInt(4);
                p.completed = rs.getBoolean(5); //rs.getInt(3)
                
                //>>>>>> dua vao ds <<<<<<
                pList.add(p);
            }
            
            //dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
        return pList;
    }
    
    public static List<Project> getCompletedProject(){
        List<Project> pList = new ArrayList<>();
        
        Connection cn = MyLib.getCN();
        try {
            //tao doi tuong statement chua link select sql
            Statement st = cn.createStatement();
            //cho thuc hien link select
            String sql = "SELECT * FROM tbProject WHERE completed = 1";
            ResultSet rs = st.executeQuery(sql);
            
            //viet vong lap
            while(rs.next()){
                //trong moi dong, doc tung cot - va tao ra 1 doi tuong MonHoc -> dua vao ds
                Project p = new Project();
                p.id = rs.getInt(1); // rs.getString(1)
                p.projectName = rs.getString(2); //rs.getString(2)
                p.startDate = rs.getString(3);
                p.value = rs.getInt(4);
                p.completed = rs.getBoolean(5); //rs.getInt(3)
                
                //>>>>>> dua vao ds <<<<<<
                pList.add(p);
            }
            
            //dong ket noi
            cn.close();
        } catch (SQLException ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
        return pList;
    }
}
