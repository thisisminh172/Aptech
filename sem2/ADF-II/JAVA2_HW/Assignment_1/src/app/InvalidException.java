
package app;


public class InvalidException extends Exception {
    public InvalidException(){
        super("Invalid data");
    }
    public InvalidException(String error){
        super(error);
    }
}
