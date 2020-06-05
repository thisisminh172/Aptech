/*
demo cach su dung bt lambda ket hop voi 1 function interface tu thiet ke
ket hop voi 1 build in function interface
 */
package lambda;

import java.util.function.*;

public class Vidu2_build_in {

    public static void main(String[] args) {
        //1. tao bieu thuc lambda dua tren inferface phia tren
        //phep cong
        BiFunction<Integer, Integer, Integer> op1 = (Integer x, Integer y) -> {
            return x + y;
        };

        //phep tru
        BiFunction<Integer, Integer, Integer> op2 = (Integer x, Integer y) -> {
            return x - y;
        };

        //phep tong binh phuong
        BiFunction<Integer, Integer, Integer> op3 = (Integer x, Integer y) -> {
            return x * x + y * y;
        };

        //thuc hien chuc nang cua 3 bieu thuc op1 op2 op3
        int a = 20;
        int b = 6;

        System.out.printf("OP1: %d + %d = %d \n", a, b, op1.apply(a, b));
        System.out.printf("OP1: %d - %d = %d \n", a, b, op2.apply(a, b));
        System.out.printf("OP1: %d^2 + %d^2 = %d \n", a, b, op3.apply(a, b));

    }

}
