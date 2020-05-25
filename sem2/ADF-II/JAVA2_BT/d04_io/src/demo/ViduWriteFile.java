/*
 * ghi 1 chuoi van ban ra 1 tap tin
 */
package demo;

import java.io.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ViduWriteFile {

    public static void main(String[] args) {
        ViduWriteFile vd = new ViduWriteFile();
        vd.writeFileBin();
        vd.writeFileBin2();
    }

    String fname = "E:\\Aptech\\git\\Aptech\\sem2\\ADF-II\\JAVA2_BT\\hoaminzy.txt";
    String fname2 = "E:\\Aptech\\git\\Aptech\\sem2\\ADF-II\\JAVA2_BT\\hoaminzy2.txt";

    String lyrics = "\nNgỡ sương sớm chạm mi mắt\n"
            + "Môi đắng lệ trĩu nặng\n"
            + "Lẳng lặng thương nhớ trong hao gầy\n"
            + "Giấu đi mối tình gục ngã\n"
            + "Hôm ấy là Thứ Ba, là ngày ta trở nên xa lạ\n"
            + "\n"
            + "\n"
            + " \n"
            + "Điều gì đã khiến anh không cầm tay em nữa\n"
            + "Có phải mình thật sự không xứng đôi?\n"
            + "Vài người vội vã cho em là người may mắn\n"
            + "Ấy thế mà… giờ anh đổi thay\n"
            + "\n"
            + "[ Chorus]\n"
            + "\n"
            + "Còn điều gì ngu ngốc bằng… lừa dối quá nhiều\n"
            + "Vẫn nghĩ mình yêu đúng người\n"
            + "Càng nhắm mắt yêu\n"
            + "Những xao xuyến khi chạm tay\n"
            + "Những háo hức tim thổn thức\n"
            + "Môi hôn tìm nhau mỗi tối\n"
            + "Chẳng còn ai thương lấy mình…ngoài chính bản thân\n"
            + "Cho em một lần cuối cùng…được nói nhớ anh\n"
            + "Có ai thoát được mình ra\n"
            + "Khỏi chân lý trong tình yêu không thể cùng nhau suốt kiếp\n"
            + "Thế nhưng trái tim lại dễ…n sâu niềm đau suốt kiếp\n"
            + "\n"
            + "[ Giang tấu ]\n"
            + "\n"
            + "Tình đã qua lâu nhưng ta cứ sống trong quá khứ\n"
            + "chứ có quên được đâu…\n"
            + "Chuyện buồn đôi ta đã hết sao chẳng thể hết tàn tạ?\n"
            + "Chỉ vì cố quên một người.\n"
            + "mà dằn vặt đến nỗi thân tâm không ngừng héo úa…";

    void writeFileBin() {
        try {
            //1. tao output stream ket noi voi file hoaminzy.txt
            FileOutputStream fos = new FileOutputStream(fname);

            //2. doc het cac byte du lieu trong chuoi lyrics -> output stream
            byte[] buffer = lyrics.getBytes();
            fos.write(buffer);

            //3. dong luong
            fos.close();

            Runtime r = Runtime.getRuntime();
            r.exec("notepad " + fname);
        } catch (Exception ex) {
            System.out.println("Loi: " + ex.getMessage());
        }

    }
    
    void writeFileBin2() {
        try {
            //1. tao output stream ket noi voi file hoaminzy.txt
            PrintStream ps = new PrintStream(fname2);

            //2. doc het cac byte du lieu trong chuoi lyrics -> output stream
            ps.println(lyrics);

            //3. dong luong
            ps.close();

            Runtime r = Runtime.getRuntime();
            r.exec("notepad " + fname2);
        } catch (Exception ex) {
            System.out.println("Loi: " + ex.getMessage());
        }

    }

}
