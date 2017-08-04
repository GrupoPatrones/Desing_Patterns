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
public class FamilyPlan extends TvPlan{

    public FamilyPlan() {
        super.description = "Plan Familia - Prepago";
    }

    @Override
    public ArrayList<Channel> channelList() {
        channelList = new ArrayList();
        channelList.add(new Channel("Fox","Series",1));
        channelList.add(new Channel("Sony","Series",2));
        channelList.add(new Channel("ESPN","Deportes",3));
        return channelList;
    }
    
    
    
}
