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
public class HBO extends PremiumPack{

    //TvPlan tvPlan_base;

    public HBO(TvPlan tvPlan_base) {
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
        channelList.add(new Channel("HBO HD","Series",101));
        channelList.add(new Channel("HBO 2 HD","Series",102));
        channelList.add(new Channel("HBO Family","Series",103));
        return channelList;
    }
    
}
