package les57_class_object;

public class TestUser {

    public static void main(String[] args) {
        User user = new User();//local variable in main method
        user.setFirstName("Sub");
        user.setLastName("Scriber");

        
        System.out.println(user.getFullName());
    }

}
