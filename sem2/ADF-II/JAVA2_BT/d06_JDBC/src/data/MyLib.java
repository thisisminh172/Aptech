/*
 * Nap driver sqljdbc42
 * tao 1 ket noi (connection) tu ung dung java den csdl (vi du, sem2_demo)
 */
package data;

import java.sql.*;//nhung goi nay khi lap trinh ve sql server
import java.util.logging.Level;
import java.util.logging.Logger;
public class MyLib {
    public static java.sql.Connection getCN(){
        Connection cn = null;
        try {
            //1. nap driver sqljdbc42
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            
            //2. tao ket noi den csdl (sem2_demo)
            String url = "jdbc:sqlserver://localhost:1433;database=sem2_demo";
            cn = DriverManager.getConnection(url,"sa","123");
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(MyLib.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(MyLib.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        return cn;
    }
}
