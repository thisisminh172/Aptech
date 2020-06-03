package app;

import java.util.Scanner;

public class Book {

    public String BookID, Title, Publisher;
    public int Price;

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.println(">>> Enter a new book");
        while (true) {
            System.out.print("Enter book id: ");
            BookID = sc.nextLine().trim();
            if (java.util.regex.Pattern.matches("B\\d{4}", BookID)) {
                break;
            }
            System.out.println(">>> The id must be : Bxxxx");
        }
        while (true) {
            System.out.print("Enter book title: ");
            Title = sc.nextLine().trim();
            if (!Title.isEmpty()) {
                break;
            }
            System.out.println(">>> The title can not be empty");
        }
        while (true) {
            try {
                System.out.print("Enter price: ");
                Price = Integer.parseInt(sc.nextLine().trim());
                if (Price >= 1 && Price <= 1000) {
                    break;
                }
                System.out.println(">>> Price must be between 1-1000");
            }catch(Exception ex){
                System.out.println("Loi: "+ex.getMessage());
            }
        }
        while (true) {
            System.out.print("Enter book publisher: ");
            Publisher = sc.nextLine().trim();
            if (java.util.regex.Pattern.matches("(OUP|CUP)", Publisher)) {
                break;
            }
            System.out.println(">>> The publisher must be [OUP] or [CUP]");
        }
    }

    @Override
    public String toString() {
        return String.format("%s , %s, %d, %s", BookID,Title,Price,Publisher);
    }
    
    public String standardizedPublisher(){
        if(Publisher.equals("OUP")){
            return "Oxford University Press";
        }else if(Publisher.equals("CUP")){
            return "Cambridge University Press";
        }
        return "Not defined";
    }
    
    
}
