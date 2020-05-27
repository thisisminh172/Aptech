
import java.util.Scanner;
import java.util.regex.*;
import java.util.zip.DataFormatException;

public class Book {

    String id, title, author, publisher;
    int pages, price;

    public Book() {
    }
    
    public Book(String id, String title, String author, String publisher, int pages, int price) {
        this.id = id;
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.pages = pages;
        this.price = price;
    }

    public void input() {
        String idPat = "B\\d{4}";
        String titlePat = "[a-z A-Z]{2,}";
        Pattern p = null;
        Matcher m = null;
        Scanner sc = new Scanner(System.in);
        while (true) {
            try {
                System.out.print("Enter book id: ");
                id = sc.nextLine().trim();
                p = Pattern.compile(idPat);
                m = p.matcher(id);
                if (m.matches()) {
                    break;
                }
                if (id.isEmpty()) {
                    System.out.println("Id can not be empty");
                }
                //throw new DataFormatException("ID must be: Bxxxx");
            } catch (Exception e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }

        while (true) {
            try {
                System.out.print("Enter book title: ");
                title = sc.nextLine().trim();
                p = Pattern.compile(titlePat, Pattern.CASE_INSENSITIVE);
                m = p.matcher(title);
                if (m.matches()) {
                    break;
                }
                if (title.isEmpty()) {
                    System.out.println("Title can not be empty");
                }
                throw new DataFormatException("Title must be at least 2 character");
            } catch (DataFormatException e) {
                System.out.println("Loi: " + e.getMessage());
            }
        }

        while (true) {
            System.out.print("Enter author name: ");
            author = sc.nextLine().trim();
            if (!author.isEmpty()) {
                break;
            }
            System.out.println("Author name cannot be empty!");
        }

        while (true) {
            System.out.print("Enter publisher: ");
            publisher = sc.nextLine().trim();
            if (!publisher.isEmpty()) {
                break;
            }
            System.out.println("Publisher cannot be empty!");
        }

        while (true) {
            try {
                System.out.print("Enter number of pages[5-2000]: ");
                pages = Integer.parseInt(sc.nextLine().trim());
                if(pages >=5 && pages<=2000){
                    break;
                }
                throw new NumberFormatException("Pages must be between 5 and 2000");
            }catch(NumberFormatException e){
                System.out.println("Loi: "+e.getMessage());
            }
        }
        
        while (true) {
            try {
                System.out.print("Enter unit price: ");
                price = Integer.parseInt(sc.nextLine().trim());
                if(price >0){
                    break;
                }
                throw new NumberFormatException("Price must be greater than 0");
            }catch(NumberFormatException e){
                System.out.println("Loi: "+e.getMessage());
            }
        }
    }

    @Override
    public String toString() {
        return "Book{" + "id=" + id + ", title=" + title + ", author=" + author + ", publisher=" + publisher + ", pages=" + pages + ", price=" + price + '}';
    }
    
    
}
