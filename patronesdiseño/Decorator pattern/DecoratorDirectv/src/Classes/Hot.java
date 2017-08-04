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
public class Hot extends PremiumPack{
    
    //TvPlan tvPlan_base;

    public Hot(TvPlan tvPlan_base) {
        this.tvPlan_base = tvPlan_base;
    }
    
    @Override
    public String getDescription() {
        return tvPlan_base.getDescription() + " + HBO";
    }

    @Override
    public ArrayList<Channel> channelList() {
        channelList = new ArrayList();
        channelList.addAll(tvPlan_base.channelList());
        channelList.add(new Channel("Venus","Adultos",301));
        channelList.add(new Channel("Playboy","Adultos",302));
        return channelList;
    }
}
