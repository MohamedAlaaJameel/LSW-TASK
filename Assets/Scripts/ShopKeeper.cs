using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : NPC
{
    // Start is called before the first frame update

    public ShopKeeper(Transform mapPos,string name, string DialogMessage)
    {
        this.name = name;
        this.mapPos = mapPos;
        this.DialogMessage = DialogMessage; 
       
    }

 

}
