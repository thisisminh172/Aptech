
import java.util.HashSet;

public class BookCatalog {

    HashSet<Book> bkList = new HashSet<>();

    public void add() {
        Book b = new Book();
        b.input();
        long cnt = bkList.stream().filter(item -> item.id.equalsIgnoreCase(b.id)).count();
        if (cnt == 0) {
            bkList.add(b);
        } else {
            System.out.println("ID is already exist");
        }
    }
    
    public void remove(String bkID){
        if(bkList.size()==0){
            System.out.println("There is no data in the system");
            return;
        }
        int cnt = 0;
        for(Book item : bkList){
            if(item.id.equals(bkID)){
                bkList.remove(item);
                cnt++;
            }
        }
        if(cnt == 0){
            System.out.println("No id is founded");
        }
    }
    
    public void display(){
        if(bkList.size()==0){
            System.out.println("There is no data in the system");
            return;
        }
        
        for(Book item : bkList){
            System.out.println(item);
        }
    }
    
    public void display(String auName){
        if(bkList.size()==0){
            System.out.println("There is no data in the system");
            return;
        }
        
        int cnt = 0;
        for (Book item : bkList){
            if(item.author.equalsIgnoreCase(auName)){
                System.out.println(item);
                cnt++;
            }
        }
        if(cnt==0){
            System.out.println("There is no author name: "+auName);
        }
    }
}
