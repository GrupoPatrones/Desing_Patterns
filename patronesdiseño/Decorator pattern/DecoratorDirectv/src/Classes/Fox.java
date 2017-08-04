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
public class Fox extends PremiumPack{
    
    //TvPlan tvPlan_base;

    public Fox(TvPlan tvPlan_base) {
        this.tvPlan_base = tvPlan_base;
    }
    
    @Override
    public String getDescription() {
        return tvPlan_base.getDescription() + " + Fox";
    }

    @Override
    public ArrayList<Channel> channelList() {
        channelList = new ArrayList();
        channelList.addAll(tvPlan_base.channelList());
        channelList.add(new Channel("Fox Premium Series HD","Series",201));
        channelList.add(new Channel("Fox Premium Family HD","Series",202));
        channelList.add(new Channel("Fox Premium Movies HD","Peliculas",203));
        return channelList;
    }
    
}
