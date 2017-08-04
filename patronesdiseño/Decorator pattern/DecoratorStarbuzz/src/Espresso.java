/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 * Clase Espresso. Componente concreto en la estructura del patron
 * @author Usuario
 */
public class Espresso extends Beverage{

    public Espresso() {
        description = "Espresso";
    }
    
    /**
     * Metodo cost. Como este es un componente concreto, es el objeto que será decorado. 
     * Por lo tanto, solo devuelve su costo, no debe realizar ningun calculo adicional
     * @return 
     */
    @Override
    public double cost(){
        return 1.99;
    }
    
}
