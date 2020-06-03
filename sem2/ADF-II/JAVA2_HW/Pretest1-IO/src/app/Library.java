package app;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.PrintStream;
import java.util.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Library {

    public static void main(String[] args) {
        Library m = new Library();
        m.Read();
        m.Menu();
    }

    HashSet<Book> bookList;
    String fname = "book.txt";

    public void Add() {
        Book b = new Book();
        b.input();
        long cnt = bookList.stream().filter(item -> item.BookID.equals(b.BookID)).count();
        if (cnt > 0) {
            System.out.println("ID is already exist, input failed");
            return;
        }
        bookList.add(b);
        System.out.println("=> Thêm sách mới thành công!!!");
    }
    
    public void Display(){
        
        if(bookList.isEmpty()){
            System.out.println("Chưa có sách trong thư viện");
            return;
        }
        int order = 1;
        System.out.println("Danh sách trong thư viện: ");
        for(Book item : bookList){
            System.out.printf("%d. %-6s %-8s %-20s\n", order,item.BookID,item.Title,item.standardizedPublisher());
        }
    }
    
    public void Save(){
        try {
            PrintStream ps = new PrintStream(fname);
            bookList.forEach(ps::println);
            ps.close();
            Runtime r = Runtime.getRuntime();
            r.exec("notepad " + fname);
        } catch (Exception ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
    }
    
    public void Read(){
        File f = new File(fname);
        if (f.exists() == false) {
            return;
        }
        bookList = new HashSet<>();
        try {
            BufferedReader br = new BufferedReader(new FileReader(fname));

            String line = null;
            while (br.ready()) {
                line = br.readLine();// doc 1 dong vb - > line
                String[] items = line.split(",");
                if (items.length == 4) {
                    Book b = new Book();
                    b.BookID = items[0].trim();
                    b.Title = items[1].trim();
                    b.Price = Integer.parseInt(items[2].trim());
                    b.Publisher = items[3].trim();

                    bookList.add(b);
                }
            }
            br.close();
        } catch (Exception ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
    }
    
    void Menu(){
        Scanner sc = new Scanner(System.in);
        String op = "";
        while(true){
            System.out.println("===MENU===");
            System.out.println("1. Xem danh mục sách");
            System.out.println("2. Thêm 1 sách mới vô thư viện");
            System.out.println("3. Lưu danh mục sách vộ tập tin văn bản");
            System.out.println("4. Thoát");
            System.out.print(">>> Enter option: ");
            op = sc.nextLine().trim();
            switch(op){
                case "1":
                    Display();
                    break;
                case "2":
                    Add();
                    break;
                case "3":
                    Save();
                    break;
                case "4":
                    System.out.println("Program ended");
                    return;
            }
        }
    }

}
