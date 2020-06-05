/*
demo cach su dung bt lambda ket hop voi 1 function interface tu thiet ke
 */
package lambda;

@FunctionalInterface
interface ICasio {

    // 1 ham truu tuong, khong the them 1 ham dc nua
    public float op(float a, float b);
}

public class Vidu1 {

    public static void main(String[] args) {
        //1. tao bieu thuc lambda dua tren inferface phia tren

        //phep cong
        ICasio op1 = (float x, float y) -> {
            return x + y;
        };

        //phep nhan
        ICasio op2 = (x, y) -> x * y;

        //tong binh phuong
        ICasio op3 = (x, y) -> {
            float a = x * x;
            float b = y * y;
            return a + b + 2 * x * y;
        };

        //thuc hien chuc nang cua 3 bieu thuc op1 op2 op3
        float a = 10;
        float b = 15;

        System.out.println("Phep cong: "+op1.op(a, b));
        System.out.println("Phep nhan: "+op2.op(a, b));
        System.out.println("Tong binh phuong: "+op3.op(a, b));

    }

}
