/*
 * demo lambda ket hop voi phuong thuc sort trong collections
 */
package lambda;

import java.util.*;

class Contact {

    public String name, email, phone;

    public Contact() {
    }

    public Contact(String name, String email, String phone) {
        this.name = name;
        this.email = email;
        this.phone = phone;
    }

    @Override
    public String toString() {
        return String.format("%s,%s,%s", name, email, phone);
    }

}

public class Vidu4 {

    public static void main(String[] args) {
        //tao danh sach cac data lien he
        List<Contact> ds = Arrays.asList(
                new Contact("lam", "lam@gmail.com", "0909123456"),
                new Contact("Minh", "MInh@gmail.com", "0909123098"),
                new Contact("Nga", "nga@gmail.com", "09091933783"),
                new Contact("Phuong", "phuong@gmail.com", "0909123444")
        );
        
        System.out.println("Danh sach contact list");
        ds.forEach(System.out::println);
        
        //sanh sach sap xep theo cot ten - cach viet ham an danh
        Collections.sort(ds, new Comparator<Contact>(){
            @Override
            public int compare(Contact o1, Contact o2) {
                return o1.name.compareTo(o2.name);
            }
        });
        
        System.out.println("danh sach contact list theo thu tu ten");
        ds.forEach(System.out::println);
        
        Collections.sort(ds, (c1,c2) -> c1.email.compareTo(c2.email));
       
        System.out.println(">>> danh sach contact list theo thu tu email");         
        ds.forEach(System.out::println);
        
        
    }

}
