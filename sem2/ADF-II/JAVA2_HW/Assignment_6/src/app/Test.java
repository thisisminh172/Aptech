
package app;

import java.util.Scanner;


public class Test {

    
    public static void main(String[] args) {
        ProductCatalog pc = new ProductCatalog();
        Scanner sc = new Scanner(System.in);
        String op = null;
        while(true){
            System.out.println("===MENU===");
            System.out.println("1. add new product ");
            System.out.println("2. input product");
            System.out.println("3. output product");
            System.out.println("4. Display the storage");
            System.out.println("5. Save file");
            System.out.println("6 exit");
            System.out.print("Choose you option: ");
            op = sc.nextLine().trim();
            String sID = null;
            float sQty = 0f;
            switch(op){
                case "1":
                    pc.add();
                    break;
                case "2":
                    System.out.print("Nhập mã sản phẩm muốn thực hiện nhập[Pxxx]: ");
                    sID = sc.nextLine().trim();
                    System.out.print("Nhập số lượng: ");
                    sQty = Float.parseFloat(sc.nextLine().trim());
                    pc.set(sID, sQty, true);
                    break;
                case "3":
                    System.out.print("Nhập mã sản phẩm muốn thực hiện xuất[Pxxx]: ");
                    sID = sc.nextLine().trim();
                    System.out.print("Nhập số lượng: ");
                    sQty = Float.parseFloat(sc.nextLine().trim());
                    pc.set(sID, sQty, false);
                    break;
                case "4":
                    System.out.println("Danh sach");
                    pc.display();
                    break;
                case "5":
                    pc.saveFile();
                    break;
                case "6":
                    return;
                default:
                    System.out.println("invalid choice");
                    
            }
        }
    }
    
}
