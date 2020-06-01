package app;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintStream;
import java.util.HashMap;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ProductCatalog {

    HashMap<String, Product> pList;
    String fname;

    public ProductCatalog() {
        pList = new HashMap<>();
        fname = "TONKHO.DAT";
        readFile();
    }

    public void add() {
        Product p = new Product();
        p.input();
        pList.put(p.id, p);

    }

    public void set(String sID, float sQty, boolean isReceive) {
        if (pList.isEmpty()) {
            System.out.println("Khong co sp trong HT");
            return;
        }
        if (isReceive == true) {
            pList.get(sID).in_qty += sQty;
        } else {
            pList.get(sID).out_qty += sQty;
        }
    }

    public void display() {
        pList.values().forEach((item) -> {
            item.output();
        });
        try {
            Runtime r = Runtime.getRuntime();
            r.exec("notepad " + fname);
        } catch (Exception ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
    }

    public void saveFile() {
        try {
            PrintStream ps = new PrintStream(fname);
            pList.values().forEach(item -> ps.println(item));
            ps.close();
        } catch (FileNotFoundException ex) {
            System.out.println("Loi: " + ex.getMessage());
        }
    }

    public void readFile() {
        try {
            BufferedReader br = new BufferedReader(new FileReader(fname));
            while (br.ready()) {
                String line = br.readLine();
                String[] items = line.split(",");
                Product p = new Product();
                p.id = items[0].trim();
                p.name = items[1].trim();
                p.price = Integer.parseInt(items[2].trim());
                p.in_qty = Float.parseFloat(items[3].trim());
                p.out_qty = Float.parseFloat(items[4].trim());

                pList.put(p.id, p);
            }
            br.close();
        } catch (FileNotFoundException ex) {
            System.out.println("Loi: " + ex.getMessage());
        } catch (IOException e) {
            System.out.println("Loi: " + e.getMessage());
        }
    }

}
