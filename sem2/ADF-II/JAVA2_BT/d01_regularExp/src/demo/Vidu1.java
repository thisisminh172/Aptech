/*
 * su dung vieu thuc quy tac de kiem tra ten cua 1 sinh vien co hop le hay khong?
ten hop le la :
    - co do dai 4-30 ky tu
    - moi ky tu chi duoc phep co gia tri a-z,A-Z hoac khoang trang
 */
package demo;

import java.util.Scanner;
import java.util.regex.Pattern;
import java.util.regex.Matcher;



public class Vidu1 {

    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Nhap vao ho ten: ");
        String fullname = sc.nextLine().trim();
        
        //1. tạo ra đối tượng pattern chứa quy tắc, để đặt tên hợp lệ.
        //quy tắc là String "[a-zA-Z ]{4,30}"
        //có độ dài từ 4-30 {4,30}
        java.util.regex.Pattern p = Pattern.compile("[a-zA-Z ]{4,30}");
        
        // tạo ra doi tượng Matcher, de thuc hien viec so sanh, voi mau quy tac p cua co trung khop khong
        //so sánh p với fullname
        //
        Matcher m = p.matcher(fullname);
        if(m.matches()){
            System.out.println("Ten nhap hop le");
        }else {
            System.out.println("Ten khong hop le, vui long nhap lai");
        }
    }
    
}
