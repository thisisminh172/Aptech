
package data;

import java.util.Scanner;


public class Customer {
    public String id,name,address;
    public int bonus;

    public Customer() {
    }

    public Customer(String id, String name, String address, int bonus) {
        this.id = id;
        this.name = name;
        this.address = address;
        this.bonus = bonus;
    }
    
    public void accept(){
        Scanner scanner = new Scanner(System.in);
        while(true){
            try{
                System.out.print("Enter id: ");
                id=scanner.nextLine().trim();
                if(id.length()>0){
                    break;
                }
                System.out.println("Không được để trống");
            }catch(Exception e){
                System.out.println("Error: "+e.getMessage());
            }
        }
        while(true){
            try{
                System.out.print("Enter name: ");
                name=scanner.nextLine().trim();
                if(name.length()>0){
                    break;
                }
                System.out.println("Không được để trống");
            }catch(Exception e){
                System.out.println("Error: "+e.getMessage());
            }
        }
        
        System.out.print("Enter address: ");
        address = scanner.nextLine().trim();
        while(true){
            try{
                System.out.print("Enter bonus: ");
                bonus = Integer.parseInt(scanner.nextLine().trim());
                if(bonus>0&&bonus<1000){
                    break;
                }
                System.out.println("giá trị không hợp lệ");
            }catch(Exception e){
                System.out.println("Error: "+e.getMessage());
            }
        }
    }

    @Override
    public String toString() {
        return "Customer{" + "id=" + id + ", name=" + name + ", address=" + address + ", bonus=" + bonus + '}';
    }
    
    
}
