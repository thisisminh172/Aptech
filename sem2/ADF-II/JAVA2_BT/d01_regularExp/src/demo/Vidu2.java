/*
 *su dung bieu thuc quy tac co phai so hop le hay khong
chi chua ky tu  so 0-9 và co it nhat 3 so
neu nhap sai -> thong bao loi va yeu cau nhap lai
 */
package demo;
import java.util.*;
import java.util.regex.*;


public class Vidu2 {

  
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String phone;
        Pattern p;
        Matcher m;
        
        p = Pattern.compile("[0-9]{3,}");
        while(true){
            System.out.print("Nhap so dien thoai: ");
            phone = sc.nextLine().trim();
            
            //khoi tao matcher
            m = p.matcher(phone);
            //kiem tra mau p co match phone hay khong
            if(m.matches()){
                //true
                break;
            }
            System.out.println("Loi: phone khong hop le, it nhat 3 ky so !!!");
        }
        System.out.println("So dien thoai: "+ phone);
    }
    
}
