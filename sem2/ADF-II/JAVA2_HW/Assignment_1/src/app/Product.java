package app;

import java.util.regex.*;
import java.util.*;

public class Product {

    public String id, name, mfg;
    public int unitPrice, qoh;
    //khai báo biến chứa regex
    public String idPat, namePat, mfgPat;

    public Product() {
    }
    
    

    public Product(String id, String name, String mfg, int unitPrice, int qoh) {
        this.id = id;
        this.name = name;
        this.mfg = mfg;
        this.unitPrice = unitPrice;
        this.qoh = qoh;
    }

    public void input() {
        Scanner scanner = new Scanner(System.in);
        Pattern p;
        Matcher m;
        idPat = "[FB]\\d{4}";
        namePat = "\\w{2,}";
        mfgPat = "(US|VN|TL)";

        while (true) {
            try {
                System.out.print("Enter product id: ");
                id = scanner.nextLine().trim();
                p = Pattern.compile(idPat);
                m = p.matcher(id);
                if (m.matches()) {
                    break;
                }
                throw new InvalidException("ID: khong hop le, Fxxxx (food) hoặc Bxxxx (beverage), với x là ký số.");
            } catch (Exception e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }

        while (true) {
            try {
                System.out.print("Enter product name: ");
                name = scanner.nextLine().trim();
                p = Pattern.compile(namePat);
                m = p.matcher(name);
                if (m.matches()) {
                    break;
                }
                throw new InvalidException("Name không hợp lệ");
            } catch (Exception e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }
        while (true) {
            try {
                System.out.print("Enter price: ");
                unitPrice = Integer.parseInt(scanner.nextLine().trim());
                if (unitPrice > 0) {
                    break;
                }
                throw new InvalidException("Giá phải là số nguyên lớn hơn 0");
            } catch (Exception e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }
        while (true) {
            try {
                System.out.print("Enter qoh: ");
                qoh = Integer.parseInt(scanner.nextLine().trim());
                if (qoh > 0) {
                    break;
                }
                throw new InvalidException("số lượng phải là số nguyên lớn hơn 0");
            } catch (Exception e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }

        while (true) {
            try {
                System.out.print("Enter country [US,VN,TL]: ");
                mfg = scanner.nextLine().trim();
                p = Pattern.compile(mfgPat,Pattern.CASE_INSENSITIVE);
                m = p.matcher(mfg);
                if (m.matches()) {
                    break;
                }
                throw new InvalidException("invalid country, must be US | VN | TL");
            } catch (Exception e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }
    }
    // method String standardlizeMFG()
    public String standardlizeMFG(){
        switch(mfg.toUpperCase()){
            case "US":
                return "United State";
            case "VN":
                return "Vietnam";
            case "TL":
                return "Thailand";
            default:
                return "There is no country: "+mfg;
        }
    }

    @Override
    public String toString() {
        return String.format("id: %s, name: %s, unit price: %d, qoh: %d, mfg: %s", id,name,unitPrice,qoh,standardlizeMFG());
    }
    
    
}
