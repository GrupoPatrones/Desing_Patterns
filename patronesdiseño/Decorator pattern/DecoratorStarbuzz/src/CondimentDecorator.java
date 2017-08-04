/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 * Clase abstracta CondimentDecorator. Decorador en la estructura del patron
 * Como extiende Beverage hereda sus metodos cost() y getDescription()
 * @author Usuario
 */
public abstract class CondimentDecorator extends Beverage{
    
    
    /**
     * Metodo abstracto getDescription. Sobreescribe la descripcion de manera abstracta
     * Esto hace que los decoradores concretos deben implementar el metodo
     * @return 
     */
    @Override
    public abstract String getDescription();
}
