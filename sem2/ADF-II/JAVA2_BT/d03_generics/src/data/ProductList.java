/*
 Quan ly danh sach san pham trong HashSet
 */
package data;

import java.util.*;
import java.io.*;
import java.util.stream.Stream;

public class ProductList {

    HashSet<Product> prList = new HashSet<>();

    public void add() {
        Product p = new Product();
        p.input();
        long cnt = prList.stream().filter(item -> item.id.equals(p.id)).count();

        if (cnt == 0) {
            prList.add(p);
        } else {
            System.out.println("Ma so da ton tai, tu choi them moi!");
        }
    }

    public void display() {
        if (prList.isEmpty()) {
            System.out.println("HT chua co du lieu");
            return;
        }

        System.out.println("Danh sach san pham");
        /*
        for (Product d : prList){
            System.out.println(d);
        }
        prList.forEach((d)-> {
            System.out.println(d);
        });
         */
        
        //Cach 3: rut gon bt lamba: method referce
        prList.forEach(System.out::println);
    }
    
    public void display(String s){
        if (prList.isEmpty()) {
            System.out.println("HT chua co du lieu");
            return;
        }
        //Stream<Product> prStream = prList.stream().filter(item -> item.name.toLowerCase().contains(s));
        prList.stream().filter(item -> item.name.toLowerCase().contains(s)).forEach(System.out::println);
    }
}
