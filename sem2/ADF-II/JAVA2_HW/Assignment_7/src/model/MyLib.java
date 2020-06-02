/*
Assginment 7
*/
package model;
import java.sql.*;


public class MyLib {
    public static Connection getCN(){
        Connection cn = null;
        try {
            //1. nap driver sqljdbc42
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            
            //2. tao ket noi den csdl (sem2_demo)
            String url = "jdbc:sqlserver://localhost:1433;database=javaDB";
            cn = DriverManager.getConnection(url,"sa","123");
        } catch (ClassNotFoundException ex) {
            System.out.println("Loi: "+ex.getMessage());
        } catch (SQLException ex) {
            System.out.println("Loi: "+ ex.getMessage());
        }
        
        return cn;
    }
    
//    public static void main(String[] args) {
//        if(MyLib.getCN()!=null){
//            System.out.println("thanh cong");
//        }else{
//            System.out.println("that bai");
//        }
//    }
}
