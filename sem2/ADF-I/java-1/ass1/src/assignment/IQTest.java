package assignment;

import java.util.Scanner;

public class IQTest {

    static int mark = 0;
    static int count = 0;
    static boolean ansE = false, ansM = false, ansA = false, ansG = false;

    public static void main(String[] args) {
        IQTest o = new IQTest();
        o.menu();
        System.out.println(mark);
    }

    void QuestionEnglish() {
        Scanner scanner = new Scanner(System.in);

        if (ansE == false) {
            System.out.println("The meannig of 'Boy' is: ");
            System.out.println("1. con trai");
            System.out.println("2. con gai");
            System.out.println("3. Ong cu");
            System.out.println("4. ba lao");
            System.out.print("The answer is [1-4]: ");
            int ans = scanner.nextInt();
            if (ans == 1) {
                mark += 10;
                count+=1;
            }
            ansE = true;

        } else {
            System.out.println("The question was answered already");
        }
    }

    void QuestionAptitude() {
        Scanner scanner = new Scanner(System.in);

        if (ansA == false) {
            System.out.println("'một hai ba bốn' là lựa chọn nào sau đây?");
            System.out.println("1. 1 hai 3 bốn");
            System.out.println("2. 2444");
            System.out.println("3. một 2 ba 4");
            System.out.println("4. 1234");
            System.out.print("The answer is [1-4]: ");
            int ans = scanner.nextInt();
            if (ans == 4) {
                mark += 10;
                count+=1;
            }
            ansA = true;

        } else {
            System.out.println("The question was answered already");
        }
    }

    void QuestionMath() {
        Scanner scanner = new Scanner(System.in);

        if (ansM == false) {
            System.out.println("Cho 1 hình chữ nhật, chiều dài 5m, chiều rộng 40cm. Diện tích hình chữ nhật là bao nhiêu?");
            System.out.println("1. 20m");
            System.out.println("2. 2m");
            System.out.println("3. 4m");
            System.out.println("4. 2cm");
            System.out.print("The answer is [1-4]: ");
            int ans = scanner.nextInt();
            if (ans == 2) {
                mark += 10;
                count+=1;
            }
            ansM = true;

        } else {
            System.out.println("The question was answered already");
        }
    }

    void QuestionGK() {
        Scanner scanner = new Scanner(System.in);

        if (ansG == false) {
            System.out.println("nhiệt độ sôi của nước là bao nhiêu?");
            System.out.println("1. 100*C");
            System.out.println("2. 90*C");
            System.out.println("3. 212*F");
            System.out.println("4. 1 & 3");
            System.out.print("The answer is [1-4]: ");
            int ans = scanner.nextInt();
            if (ans == 2) {
                mark += 10;
                count+=1;
            }
            ansG = true;

        } else {
            System.out.println("The question was answered already");
        }
    }

    void menu() {
        IQTest q = new IQTest();
        Scanner scanner = new Scanner(System.in);
        int option = 0;
        do {
            System.out.println("Test IQ: ");
            System.out.println("1. English");
            System.out.println("2. Aptitude");
            System.out.println("3. Mathematics");
            System.out.println("4. General Knowledge");
            System.out.println("5. Exit");
            System.out.print("Please choose from 1 - 5: ");
            option = scanner.nextInt();

            switch (option) {
                case 1:
                    q.QuestionEnglish();
                    break;
                case 2:
                    q.QuestionAptitude();
                    break;
                case 3:
                    q.QuestionMath();
                    break;
                case 4:
                    q.QuestionGK();
                    break;
                case 5:
                    if(ansE && ansA && ansM && ansG){
                        if(count==1){
                            System.out.println("your total is "+mark+" and have no bonus");
                            System.out.println("Your IQ level is below average");
                        }else if(count==2){                           
                            System.out.println("your mark is "+mark+" and bonus is 2");
                            mark = mark + 2;
                            System.out.println("Your total mark is "+mark);
                            System.out.println("Your IQ level is average");
                        }else if(count==3){                           
                            System.out.println("your mark is "+mark+" and bonus is 5");
                            mark = mark + 5;
                            System.out.println("Your total mark is "+mark);
                            System.out.println("You are intelligent");
                        }else if(count==4){                           
                            System.out.println("your mark is "+mark+" and bonus is 10");
                            mark = mark + 10;
                            System.out.println("Your total mark is "+mark);
                            System.out.println("You are a genius");
                        }
                        
                    }else{
                        System.out.println("Cannot exit program");
                    }
                    break;
                default:
                    System.out.println("Please choose in the range 1- 5");
                    break;
            }
        } while (option != 5);
    }

}
