/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 * Clase Mocha. Decorador concreto en la estructura del patron
 * @author Usuario
 */
public class Mocha extends CondimentDecorator{
    //Componente que sera decorado por Mocha
    Beverage beverage;
    
    /**
     * Constructor. Recibimos directamente la bebida a ser decorado pues de otra manera no debe existir el condimento
     * @param beverage 
     */
    public Mocha(Beverage beverage){
        this.beverage = beverage;
    }
    
    /**
     * Metodo getDescription. Sobreescribimos este metodo añadiendo a la description de la bebida decorada el condimento añadido
     * @return 
     */
    @Override
    public String getDescription() {
        return beverage.getDescription() + ", Mocha";
    }
    
    /**
     * Metodo cost(). Sobreescribimos este metodo sumando al costo de la bebida decorada el costo de este condimento
     * @return 
     */
    @Override
    public double cost() {
        return .20 + beverage.cost();
    }
    
}
