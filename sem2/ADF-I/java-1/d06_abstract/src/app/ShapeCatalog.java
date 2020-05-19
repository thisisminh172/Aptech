/*
 * Lop quan ly danh sach doi tuong hinh hoc: hinh tron, hinh chu nhat
 */
package app;

import data.*;

public class ShapeCatalog {

    //khai bao mang chua cac doi tuong hinh hoc
    final int max = 10;
    int index = 0;
    //khai bao mang chua cac doi tuong hinh hoc
    Shape[] ds = new Shape[max];
    
    //ham them 1 doi tuong hinh hoc
    public void addRect(){
        if(index == max){
            System.out.println("HT het cho luu tru");
            return;
        }
        Shape r = new Rectangle();
        r.input();
        
        ds[index] = r;
        index++;
    }
    
    //them 1 doi tuong hinh tron
    public void addCircle(){
        if(index == max){
            System.out.println("HT het cho luu tru");
            return;
        }
        Shape c = new Circle();
        c.input();
        
        ds[index] = c;
        index++;
    }
    
    //in ds hinh hoc
    public void display(){
        //kiem tra da co du lieu chua
        if(index==0){
            System.out.println(">>HT chua co du lieu");
            return;
        }else{
            System.out.println(">>DS doi tuong hinh hoc");
            for (int i = 0; i < index; i++) {
                ds[i].output();
            }
        }
    }
    
    public void displaySquare(){
        if(index==0){
            System.out.println(">>HT chua co du lieu!!!");
            return;
        }
        int demSquare = 0;
        for (int i = 0; i < index; i++) {
            if(ds[i] instanceof Rectangle){
                Rectangle r =(Rectangle) ds[i];
                if(r.length==r.width){
                    ds[i].output();
                    demSquare++;
                }
            }
            ds[i].output();
        }
        
        if(demSquare == 0){
            System.out.println("DS không có hình vuông");
        }
    }

}
