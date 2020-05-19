package assignment;

import java.util.Scanner;

public class AccountTest {

    public static void main(String[] args) {
        AccountTest o = new AccountTest();
        o.menu();

    }

    void menu() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Nhập số tài khoản: ");
        String accNo = scanner.nextLine();
        System.out.print("Nhập số dư: ");
        int balance = scanner.nextInt();
        Account a = new Account(accNo,balance);//khởi tạo hàm dựng

        int option = 0, amt = 0;
        do {
            System.out.println("Hệ thống rút/gởi tiền tự động: ");
            System.out.println("1. deposit");
            System.out.println("2. withdraw");
            System.out.println("3. xem số dư");
            System.out.println("4. thoát");
            System.out.print("Chọn chức năng 1- 4: ");
            option = scanner.nextInt();
            switch (option) {
                case 1:
                    System.out.print("Nhập số tiền muốn gửi: ");
                    amt = scanner.nextInt();
                    a.deposit(amt);
                    break;
                case 2:
                    System.out.println("Nhập số tiền muốn rút: ");
                    amt = scanner.nextInt();
                    a.withdraw(amt);
                    break;
                case 3:
                    System.out.println("============================");
                    System.out.printf("Số tk : %s\n", a.getAcc());
                    System.out.printf("Số dư = %d\n", a.getBalance());
                    System.out.println("============================");
                    break;
                case 4:
                    System.out.println("bạn chọn kết thúc dịch vụ");
                    break;
                default:
                    System.out.println("vui lòng chọn đúng chức năng");
                    break;
            }
        } while (option != 4);
        System.out.println("Cảm ơn đã sử dụng dịch vụ! bye bye...");
    }

}
