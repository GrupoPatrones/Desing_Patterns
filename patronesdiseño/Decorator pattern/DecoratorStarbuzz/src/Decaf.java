/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author Usuario
 */
public class Decaf  extends Beverage{

    public Decaf() {
        description = "Dark Roasts Coffee";
    }
    
    @Override
    public double cost(){
        return 1.05;
    }
    
}
