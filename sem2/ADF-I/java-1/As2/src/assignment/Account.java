package assignment;

public class Account {

    String accNo;
    int balance;

    public Account() {
        accNo = "ACC01";
        balance = 100;
    }

    public Account(String acc, int bal) {
        accNo = acc;
        balance = bal;
    }

    public void deposit(int amt) {
        if (amt > 0 && amt >100) {
            balance = balance + amt;
            System.out.println("Giao dịch thành công");
        } else {
            System.out.println("Cannot input nagative value");
        }
    }

    public void withdraw(int amt) {
        if (amt > 0 && amt < balance && amt>100) {
            balance = balance - amt;
            System.out.println("Giao dịch thành công");
        } else {
            System.out.println("Giao dịch thất bại");
        }
    }

    public int getBalance() {
        return balance;
    }
    public String getAcc(){
        return accNo;
    }

}
