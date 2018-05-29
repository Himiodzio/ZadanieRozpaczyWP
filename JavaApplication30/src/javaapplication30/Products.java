package javaapplication30;

import java.util.ArrayList;

public class Products implements ProductsInterface {
    
    private double _min;
    private double _max;
                
    public Products(double min, double max) {
        this._min = min;
        this._max = max;
    }
    
    @Override
    public String getList(double price) {
        if (price > this._min && price <= this._max) {
            return "Lista produktow: " + this._min + " do " + this._max;
        }
        
        return null;
    }
    
}
