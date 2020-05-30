/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app;
import data.*;


public class TestConnect {

    
    public static void main(String[] args) {
        if(data.MyLib.getCN()==null){
            System.out.println("Fail");
        }else{
            System.out.println("thanh cong roi");
        }
    }
    
}
