
package Electronics;

import java.util.Scanner;


public class TelevisionCatalog {
    public int count,max;
    Television[] tvList;

    public TelevisionCatalog() {
        count = 0;
        max=4;
        tvList= new Television[max];
    }
    
    public void add(){
        if(count==max){
            System.out.println("HT het du lieu");
            return;
        }
        Television tv = new Television();
        tvList[count]=tv;
        count++;
    }
    public void searchByBrand(){
        Scanner scanner = new Scanner(System.in);
        if(count==0){
            System.out.println(">>> Chua co sp <<<");
            return;
        }
        
        System.out.print("Enter the brand: ");
        String br = scanner.nextLine().trim();
        for (int i = 0; i < count; i++) {
            if(tvList[i].brand.contains(br)){
                tvList[i].printInfo();
            }
        }
    }
    
    public void displayAll(){
        if(count==0){
            System.out.println(">>> Chua co sp <<<");
            return;
        }
        
        for (int i = 0; i < count; i++) {
            tvList[i].printInfo();
        }
    }
    
    public void displayHighValue(){
        if(count==0){
            System.out.println(">>> Chua co sp <<<");
            return;
        }
        
        for (int i = 0; i < count; i++) {
            if(tvList[i].getCost()>500){
                tvList[i].printInfo();
            }
        }
    }
    
}
