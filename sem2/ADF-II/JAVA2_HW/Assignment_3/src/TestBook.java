
import java.util.Scanner;


public class TestBook {

    
    public static void main(String[] args) {
        TestBook m = new TestBook();
        m.menu();
    }
    
    public void menu(){
        BookCatalog b = new BookCatalog();
        Scanner sc = new Scanner(System.in);
        String op = "";
        while(true){
            System.out.println("===MENU===");
            System.out.println("1. Add a book");
            System.out.println("2. Remove a book by id");
            System.out.println("3. Display all books");
            System.out.println("4. Find the book with author's name: ");
            System.out.println("5. Exit");
            System.out.print("Choose your option: ");
            op = sc.nextLine().trim();
            switch(op){
                case "1":
                    b.add();
                    break;
                case "2":
                    System.out.print("Enter id you want to remove: ");
                    b.remove(sc.nextLine().trim());
                    break;
                case "3":
                    b.display();
                    break;
                case "4":
                    System.out.print("Enter author name: ");
                    b.display(sc.nextLine().trim());
                    break;
                case "5":
                    return;
            }
        }
    }
    
}
