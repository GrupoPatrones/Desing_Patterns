
import Classes.FamilyPlan;
import Classes.Fox;
import Classes.HBO;
import Classes.SilverPlan;
import Classes.TvPlan;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Usuario
 */
public class DirectvTV {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //Cliente prepago basico
        TvPlan cliente1 = new FamilyPlan();
        System.out.println(cliente1.getDescription() + "\n" + cliente1.channelList().toString());
        
        //Cliente pospago basico
        TvPlan cliente2 = new SilverPlan();
        cliente2 = new HBO(cliente2);
        cliente2 = new Fox(cliente2);
        System.out.println("\n\n" + cliente2.getDescription() + "\n" + cliente2.channelList().toString());
    }
    
}
