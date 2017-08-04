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
public abstract class TvPlan {
    protected ArrayList<Channel> channelList;
    protected String description;
    
    public String getDescription() {
        return description;
    }
    
    public abstract ArrayList<Channel> channelList();
}
