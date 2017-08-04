/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Classes;

/**
 * Clase canal. No hace parte de la estructura del patron
 * @author Usuario
 */
public class Channel {
    private String name;
    private String description;
    private int number;

    public Channel() {
    }

    public Channel(String name, String description, int number) {
        this.name = name;
        this.description = description;
        this.number = number;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }
    
    @Override
    public String toString(){
        return "Canal: " + this.name + "\nDescripcion: " + this.description + "\nNumero en la grilla: " + this.number;
    }
    
}
