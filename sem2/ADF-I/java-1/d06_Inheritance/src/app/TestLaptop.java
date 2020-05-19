/*
 * kiem tra lop laptop
 */
package app;

import data.Computer;
import data.Laptop;
import java.util.Scanner;

public class TestLaptop {

    public static void main(String[] args) {

        Laptop c1 = new Laptop();
        //Kieu khai bao bien = kieu doi tuong (type of object): Laptop
        //Kieu cap phat bo nho = kieu tham chieu(type of reference) c1: Laptop
        c1.input();
        c1.display();

        Computer c2 = new Computer();
        //Kieu khai bao bien = kieu doi tuong (type of object): Computer
        //Kieu cap phat bo nho = kieu tham chieu(type of reference) c2: Computer
        c2.input();
        c2.display();

        Computer c3 = new Laptop();
        //phuong thuc Override
        c3.input();
        c3.display();
        
        
        /*
        //ứng dụng phuong thuc @Override
        Computer[] listCom = new Computer[10];
        listCom[0] = new Laptop();
        listCom[1] = new Computer();
         */

    }

}
