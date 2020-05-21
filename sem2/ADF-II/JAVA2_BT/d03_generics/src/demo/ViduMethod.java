package demo;

public class ViduMethod {

    String[] tensv = {"Phong", "Minh", "Thach", "Lam", "Thang"};
    int[] diem = {30, 40, 50, 60, 70};

    void display(String[] dsTen) {
        for (String item : dsTen) {
            System.out.println(item);
        }
    }

    void display(int[] dsDiem) {
        for (int item : dsDiem) {
            System.out.println(item);
        }
    }

    public static void main(String[] args) {
        ViduMethod vd = new ViduMethod();
        System.out.println("\n Danh sach ten sv");
        vd.display(vd.tensv);
        
        System.out.println("\n Bang diem");
        vd.display(vd.diem);
    }

}
