using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum EquipType { None,rightHand,LeftHand,Helmet,UpperBody,LowerBody }

 //[CreateAssetMenu(items)]
public class Item 

{

    SpriteRenderer ItemSprite;
    Image image;
    string ItemName;
    int ItemID;
    int randID;
    EquipType itemType;
 
 

    public Image Image
    {
        get { return image; }
        set { image = value; }
    }


}
