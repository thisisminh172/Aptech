
package demo;


public class ViduMethodGeneric {

    String[] tensv = {"Phong", "Minh", "Thach", "Lam", "Thang"};
    Integer[] diem = {30, 40, 50, 60, 70};

    <T>void display(T[] ds) {
        for (T item : ds) {
            System.out.println(item);
        }
    }

    
    public static void main(String[] args) {
        ViduMethodGeneric vd = new ViduMethodGeneric();
        System.out.println("\n Danh sach ten sv");
        vd.display(vd.tensv);
        
        System.out.println("\n Bang diem");
        vd.display(vd.diem);
    }
    
}
