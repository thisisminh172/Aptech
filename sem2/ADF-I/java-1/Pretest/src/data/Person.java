
package data;

import java.util.Scanner;


public abstract class Person {
    public String id,name;
    public int yob;

    public Person(String id, String name, int yob) {
        this.id = id;
        this.name = name;
        this.yob = yob;
    }
    public void accept(){
        Scanner scanner = new Scanner(System.in);
        while(true){
            try{
                System.out.print("Enter id: ");
                id = scanner.nextLine().trim();
                if(!id.isEmpty()){
                    break;
                }
                System.out.println("Can not leave empty");
            }catch(Exception e){
                System.out.println("Error: "+e.getMessage());
            }
        }
        while(true){
            try{
                System.out.print("Enter name: ");
                name = scanner.nextLine().trim();
                if(!name.isEmpty()){
                    break;
                }
                System.out.println("Can not leave empty");
            }catch(Exception e){
                System.out.println("Error: "+e.getMessage());
            }
        }
        
        while(true){
            try{
                System.out.print("Enter yob: ");
                yob = Integer.parseInt(scanner.nextLine().trim());
                if(yob>=1940&&yob<=2000){
                    break;
                }
                System.out.println("Invalid year");
            }catch(Exception e){
                System.out.println("Error: "+e.getMessage());
            }
        }
    }
    public void printInfo(){
        System.out.println("id: "+id);
        System.out.println("name: "+name);
        System.out.println("yob: "+yob);
    }
}
