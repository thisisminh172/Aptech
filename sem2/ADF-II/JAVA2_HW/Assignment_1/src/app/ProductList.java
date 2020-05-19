
package app;

import java.util.ArrayList;


public class ProductList {
    ArrayList<Product> prList = new ArrayList<Product>();
    public void addProduct(){
        Product n = new Product();
        n.input();
        prList.add(n);
    }
    
    public void displayAll(){
        if(prList.isEmpty()){
            System.out.println("Khong co sp trong ds");
            return;
        }
        for(Product item : prList){
            System.out.println(item);
        }
    }
    
    public void searchByName(String name){
        if(prList.isEmpty()){
            System.out.println("Khong co sp trong ds");
            return;
        }
        int count = 0;
        for (int i = 0; i < prList.size(); i++) {
            if(prList.get(i).name.contains(name)){
                System.out.println(prList.get(i));
                count++;
            }
        }
        if(count==0){
            System.out.println("Không tìm thấy tên trong danh sách");
        }
    }
}
