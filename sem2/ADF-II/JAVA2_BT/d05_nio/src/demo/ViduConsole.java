package demo;


public class ViduConsole {

    
    public static void main(String[] args) {
        java.io.Console cs = System.console();
        cs.printf("nhap 1 chuoi ky tu: ");
        String s = cs.readLine();
        
        cs.printf("Nhap password: ");
        String pw = new String(cs.readPassword());
        
        cs.printf("\nTai khoan: %s \n", s);
        cs.printf("\nPassword: %s\n",pw);
    }
    
}
