/*
class User
 */
package les57_class_object;

public class User {

    private String firstName;
    private String lastName;

    public String output() {
        return ("Hi, my name is "+firstName + " " + lastName+".");

    }
    
    public String getFirstName(){
        return firstName.toUpperCase();
    }
    public void setFirstName(String fn){
        firstName = fn.trim();
    }
    public String getLastName(){
        return lastName.toUpperCase();
    }
    public void setLastName(String ln){
        lastName = ln.trim().toLowerCase();
    }
    
    public String getFullName(){
        return getFirstName()+" "+lastName;
    }
}
