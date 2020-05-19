/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demo;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class Vidu2a {

    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String phone;
        Pattern p;
        Matcher m;

        p = Pattern.compile("\\d{3,}");
        while (true) {
            System.out.print("Nhap so dien thoai: ");
            phone = sc.nextLine().trim();

            //khoi tao matcher
            m = p.matcher(phone);
            //kiem tra mau p co match phone hay khong
            if (m.matches()) {
                //true
                break;
            }
            System.out.println("Loi: phone khong hop le, it nhat 3 ky so !!!");
        }
        System.out.println("So dien thoai: " + phone);
    }

}
