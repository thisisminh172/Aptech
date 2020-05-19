
package assignment;

import java.util.Scanner;


public class Doctor {
    String docNo, name, specification;
    int exp_years, salary;
    public Doctor(){
        docNo = "";
        name ="";
        specification="";
        exp_years = 0;
        salary = 0;
    }
    public Doctor(String docNo, String name, String specification,int exp_years,int salary){
        this.docNo = docNo;
        this.name =name;
        this.specification=specification;
        this.exp_years = exp_years;
        this.salary = salary;
    }
    
    void input(){
        Scanner scanner = new Scanner(System.in);
        int n = 0;
        while(n!=1){
            System.out.print("enter doctor number: ");
            docNo = scanner.nextLine();
            if(docNo != ""){
                n =1;
                
            }
        }
    }
    
}
