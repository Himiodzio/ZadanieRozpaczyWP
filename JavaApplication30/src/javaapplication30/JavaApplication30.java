package javaapplication30;

import java.util.Scanner;

public class JavaApplication30 {

    public static void main(String[] args) {
        ListOfProducts ob = new ListOfProducts();
        ob.addList(0, 50).addList(50, 100).addList(100, 200);

        Scanner sc = new Scanner(System.in);
        double user = sc.nextDouble();
        while (user > 0.0) {
            ob.showProducts(user);
            user = sc.nextDouble();
        }
        
        ob.deleteItem();
        
        user = sc.nextDouble();
        while (user > 0.0) {
            ob.showProducts(user);
            user = sc.nextDouble();
        }
    }

}
