/**
 * demo ve 1 so chuc nang cua java.time
 *
 */
package timeAPI;

import java.util.Scanner;
import java.time.*;
import java.time.temporal.ChronoUnit;
import java.time.temporal.TemporalAdjuster;
import java.time.temporal.TemporalAdjusters;
import java.text.SimpleDateFormat;

public class Demo {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String op = null;
        while (true) {
            System.out.println("\n === DEMO java.time ===");
            System.out.println("1. LocalDate");
            System.out.println("2. LocalDateTime");
            System.out.println("3. MonthDay");
            System.out.println("4. offsetTime");
            System.out.println("5. period");
            System.out.println("6. TemporalAdjuster");
            System.out.println("10. Thoat");

            System.out.print("Vui long chon chua nang: ");
            op = sc.nextLine().trim();
            switch (op) {
                case "1":
                    localDate();
                    break;
                case "2":
                    localDateTime();
                    break;
                case "3":
                    monthDay();
                    break;
                case "4":
                    offsetTime();
                    break;
                case "5":
                    period();
                    break;
                case "6":
                    temporal();
                    break;
                case "10":
                    return;
            }
        }
    }

    static void localDate() {
        LocalDate o = LocalDate.now();
        System.out.println("Local Date: " + o);
        System.out.println("Next 34 days: " + o.plusDays(34));
        System.out.println("Precious 14 days: " + o.minusDays(14));
    }

    static void localDateTime() {
        LocalDateTime d = LocalDateTime.of(2000, 7, 21, 8, 30);
        System.out.println("Local date time: " + d);
        System.out.println("next 112 minutes: " + d.plusMinutes(112));
    }

    static void monthDay() {
        MonthDay md1 = MonthDay.now();
        System.out.println("Month,Day of today: " + md1);
        MonthDay md2 = MonthDay.of(10, 8);

        if (md1.equals(md2)) {
            System.out.println("Chuc mung sinh nhat");
        } else {
            System.out.println("ko co su kien gi het");
        }
    }

    static void offsetTime() {
        OffsetTime ost = OffsetTime.now();
        System.out.println("Offset time: " + ost);
    }

    static void period() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Nhap ngay sinh cua ban: ");
        System.out.print("Ngay: ");
        int d = Integer.parseInt(sc.nextLine().trim());
        System.out.print("Thang: ");
        int m = Integer.parseInt(sc.nextLine().trim());
        System.out.print("Nam: ");
        int y = Integer.parseInt(sc.nextLine().trim());

        LocalDate bd = LocalDate.of(y, m, d); //ngay sinh
        LocalDate today = LocalDate.now(); //hom nay

        LocalDate bd2 = bd.withYear(today.getYear()); //ngay sinh cua ban trong nam nay

        if (bd2.isBefore(today) || bd2.equals(today)) {
            //ngay sinh nhat da qua roi hoac hom nay
            bd2 = bd2.plusYears(1); //gan gia tri

        }

        Period p = Period.between(today, bd2); //tinh khoang cach thoi gian ngay hom nay va ngay sinh cua ban
        System.out.println("ngay sinh nhat trong nam: "+bd2);
        System.out.printf("\n con %d thang, %d ngay nua la den sinh nhat cua ban! \n", p.getMonths(), p.getDays());
        System.out.printf("\n Chinh xac la con cho %d ngay", ChronoUnit.DAYS.between(today, bd2));

    }
    
    static void temporal(){
        LocalDate today = LocalDate.now();
        LocalDate examDate = today.with(TemporalAdjusters.next(DayOfWeek.THURSDAY));
        System.out.println("Ngay thi ADF-I: "+examDate);
    }
    
    static void dateFormat(){
        java.util.Date today = new java.util.Date();
        //LocalDate today = LocalDate.now();
        System.out.println("today is: "+today);
        java.text.SimpleDateFormat sdf = new SimpleDateFormat("dd,MMM yyyy");
    }

}
