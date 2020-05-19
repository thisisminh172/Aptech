/*
Su dung bieu thuc quy tac, kiem tra nhap ten co hop le hay khong
ten hop le - được mô tả trong Vidu1.
neu nhap sai - thong bao loi va yeu cau nhap lai.
 */
package demo;

import java.util.regex.*;
import java.util.*;

public class Vidu1a {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String tenSV;
        Pattern p;
        Matcher m;
        p = Pattern.compile("[a-z ]{4,30}",Pattern.CASE_INSENSITIVE);
        
        
        while (true) {
            System.out.print("Nhap ten sinh vien: ");
            tenSV = sc.nextLine().trim();
            m = p.matcher(tenSV);
            if(m.matches()){
                break;//nhap dung thoat vong lap while
            }
            System.out.println("Ten ko hop le! chua tu 4-5 ky tu chu !");
        }
        
        System.out.println("Ten sinh vien: "+ tenSV);
    }

}
