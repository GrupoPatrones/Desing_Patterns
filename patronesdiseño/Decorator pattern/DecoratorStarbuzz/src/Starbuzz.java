/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Usuario
 */
public class Starbuzz {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //Un cliente ordena un espresso
        Beverage beverage = new Espresso();
        System.out.println(beverage.getDescription() + " $" + beverage.cost());
        
        //Otro cliente ordena un DarkRoast
        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);//Y añade Mocha
        //beverage2 = new Mocha(beverage2);//Y añade otro Mocha
        beverage2 = new Whip(beverage2);//Y añade Whip
        System.out.println(beverage2.getDescription() + " $" + beverage2.cost());
        
        //Otro clinte ordena un HouseBlend
        Beverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);//Y añade Soy
        beverage3 = new Mocha(beverage3);//Y añade Mocha
        beverage3 = new Whip(beverage3);//Y añade Whip
        System.out.println(beverage3.getDescription() + " $" + beverage3.cost());
    }
    
}
