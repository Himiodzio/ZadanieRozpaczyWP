package javaapplication30;

import java.util.ArrayList;

public class ListOfProducts {
    private ArrayList<ProductsInterface> products;
    
    public ListOfProducts() {
        this.products = new ArrayList<>();
    }
    
    public void showProducts(double price) {
        String temp = null;
        
        for (ProductsInterface ob : this.products) {
            temp = ob.getList(price);
            if (temp != null) {
                break;
            }
        }
        
        if (temp == null)
            System.err.println("Nie znaleziono");
        else
            System.err.println(temp);
    }
    
    public ListOfProducts addList(double min, double max) {
        this.products.add(new Products(min, max));
        
        return this;
    }
    
    public ListOfProducts deleteItem() {
        this.products.remove(1);
        return this;
    }
}
