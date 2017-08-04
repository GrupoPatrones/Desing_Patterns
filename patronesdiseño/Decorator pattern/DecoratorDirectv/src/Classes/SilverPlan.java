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
public class SilverPlan extends TvPlan{

    public SilverPlan() {
        super.description = "Plan Plata Full HD - Pospago";
    }

    @Override
    public ArrayList<Channel> channelList() {
        channelList = new ArrayList();
        channelList.add(new Channel("Comedy Central","Comedia",10));
        channelList.add(new Channel("NatGeo Kids","Infantil",123));
        channelList.add(new Channel("Cinemax","Peliculas",109));
        return channelList;
    }
    
}
