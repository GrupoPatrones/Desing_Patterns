/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Classes;

import java.util.ArrayList;

/**
 *
 * @author Usuario
 */
public class GoldPlan extends TvPlan{

    public GoldPlan() {
        super.description = "Plan Oro Full HD - Pospago";
    }

    @Override
    public ArrayList<Channel> channelList() {
        channelList = new ArrayList();
        channelList.add(new Channel("Golden Edge","Peliculas",45));
        channelList.add(new Channel("Directv Sports +","Deportes",109));
        channelList.add(new Channel("ESPN 3","Deportes",200));
        return channelList;
    }
    
}
