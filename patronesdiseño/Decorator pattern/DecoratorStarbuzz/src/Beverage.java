/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 * Clase abstracta Beverage. Componente en la estructura del patrón decorador
 * @author Usuario
 */
public abstract class Beverage {
    String description = "Unknown Beverage";

    public String getDescription() {
        return description;
    }
    /**
     * Metodo abstracto que debe ser implementado por las clases que los hereden, tanto los componentes concretos
     * como los decoradores
     * @return Debe devolver el costo añadido a todos los objetos que han sido decorados anteriormente
     */
    public abstract double cost();
}
