/*
 * su dung bieu thuc quy tac, kiem tra nhap ma so sinh vien co hop le hay khong
ma so hop le:
 co ky tu bat dau la s hoac h
 sau co là day so từ 5-8 ky so
 */
package demo;

import java.util.Scanner;
import java.util.regex.*;


public class Vidu3 {

    
    public static void main(String[] args) {
        Scanner sc =  new Scanner(System.in);
        String id;
        Pattern p;
        Matcher m;
        
        p = Pattern.compile("[SH]\\d{5,8}");
        
        while (true) {
            System.out.print("Nhap so sinh vien: ");
            id = sc.nextLine().trim();

            //khoi tao matcher
            m = p.matcher(id);
            //kiem tra mau p co match phone hay khong
            if (m.matches()) {
                //true
                break;
            }
            System.out.println("Loi: id khong hop le!!!");
        }
        System.out.println("So sinh vien: " + id);
    }
    
}
