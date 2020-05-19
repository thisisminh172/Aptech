/*
 * kiem tra ma so trung tam co  hop le hay khong
    ma so hop le:
 HN hoac SG hoac DN hoac CT
neu nhap sai -> thong bao loi va yeu cau nhap lai.
 */
package demo;

import java.util.Scanner;
import java.util.regex.*;

public class Vidu4 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String center;
        Pattern p;
        Matcher m;
        p = Pattern.compile("(HN|SG|HCMC|CT|DN)", Pattern.CASE_INSENSITIVE);
        
        while (true) {
            System.out.print("Nhap ma trung tam: ");
            center = sc.nextLine().trim();

            //khoi tao matcher
            m = p.matcher(center);
            //kiem tra mau p co match center hay khong
            if (m.matches()) {
                //true
                break;
            }
            System.out.println("Loi: center khong hop le!!!");
            System.out.println("hoac HN,HCMC,SG,CT,DN");
        }
        System.out.println("ma trung tam: " + center);
        
        //de kiem tra, chung ta co the su dung ham
        // - lookingAt(): luat p xuat hien o dau chuoi center =>VD:"HN, Quan Hoan Kiem"
        // - find() : luat p xuat hien trong chuoi center  => Vd: "SG, quan 3","quan 3,SG. FPTAPTECH"
        // - matches() : luat p phai giong y chang chuoi center =>VD: "SG"
    }

}
