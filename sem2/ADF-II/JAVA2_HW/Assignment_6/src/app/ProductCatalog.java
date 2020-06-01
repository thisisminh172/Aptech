
package app;

import java.util.HashMap;


public class ProductCatalog {
    HashMap<String,Product> pList;
    String fname;

    public ProductCatalog() {
        pList = new HashMap<>();
        fname = "TONKHO.DAT"; 
    }
    
    public void add(){
        Product p = new Product();
        pList.put(p.id, p);
        
    }
    
    public void set(String sID,float sQty,boolean isReceive){
        if(isReceive == true){
            pList.get(sID).in_qty += sQty;
        }else{
            pList.get(sID).out_qty += sQty;
        }
    }
    
    public void display(){
        pList.values().forEach((item) -> {
            item.output();
        });
    }
    
    public void saveFile(){
        
    }
    
    

    
    
    
}
