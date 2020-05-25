/*
 * danh sach cac san pham
bao gom: add, display, read, write
 */
package data;
import java.util.*;
import java.io.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ProductList {
    HashSet<Product> ds = new HashSet<Product>();
    
    public void add(){
        Product p = new Product();
        Scanner sc = new Scanner(System.in);
        
        System.out.print("Nhap ma so SP: ");
        p.id = sc.nextLine().trim();
        if(ds.stream().filter(item -> item.id.equals(p.id)).count()>0){
            System.out.println("Loi: id ton tai. tu choi thao tac");
            return;
        }
        System.out.print("Nhap ten sp: ");
        p.name = sc.nextLine().trim();
        
        System.out.print("Nhap don gia SP: ");
        p.price = Integer.parseInt(sc.nextLine().trim());
        
        //dua sp vo ds
        ds.add(p);
    }
    
    public void display(){
        if(ds.isEmpty()){
            System.out.println("Loi HT chua co du lieu");
            return;
        }
        System.out.println("Danh sach san pham");
        ds.forEach(System.out::println);
    }
    
    String fname = "SanPham.txt";
    
    public void SaveFileText(){
        if(ds.isEmpty()){
            System.out.println("Loi HT chua co du lieu");
            return;
        }
        
        try {
            //1. open outputstream
            PrintStream ps = new PrintStream(fname);
            //2. ghi toan bo du lieu trong danh sach vo output stream
            ds.forEach(ps::println);
            //ds.forEach(item->ps.println(item));
            //3. close
            ps.close();
        } catch (Exception ex) {
            System.out.println("Loi: "+ex.getMessage());
        }
        
    }
    
    public void LoadFileText(){
        File f = new File(fname);
        if(f.exists() == false){
            return;
        }
        
        ds = new HashSet<>();
        
        try {
            BufferedReader br = new BufferedReader(new FileReader(fname));
            
            String line = null;
            while(br.ready()){
                line = br.readLine();// doc 1 dong vb - > line
                String[] items = line.split(",");
                if(items.length==3){
                    Product p = new Product();
                    p.id = items[0].trim();
                    p.name = items[1].trim();
                    p.price = Integer.parseInt(items[2].trim());
                    
                    ds.add(p);
                }
            }
            br.close();
        } catch (Exception ex) {
            System.out.println("Loi: "+ ex.getMessage());
        }
    }
}
