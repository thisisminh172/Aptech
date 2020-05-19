
package data;


public class CustomerCatalog {
    Customer[] cList = new Customer[10];
    
    public int count;

    public CustomerCatalog() {
        count = 0;
    }
    
    public void add(){
        if(count == 10){
            System.out.println("HT het du cho trong");
            return;
        }
        
        Customer c = new Customer();
        c.accept();
        cList[count]=c;
        count++;
    }
    
    public void searchByName(String name){
        if(count==0){
            System.out.println("No customer in the system");
            return;
        }
        int temp = 0;
        
        for (int i = 0; i < count; i++) {
            if(cList[i].name.contains(name)){
                System.out.println(cList[i]);
                temp++;
            }
        }
        
        if(temp==0){
            System.out.println("Can not find the customer's name: "+name);
        }
    }
    
    public void displayAll(){
        if(count==0){
            System.out.println("No customer in the system");
            return;
        }
        
        for (int i = 0; i < count; i++) {
            System.out.println(cList[i]);
        }
    }
    
}
