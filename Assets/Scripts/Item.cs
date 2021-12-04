using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EquipType { None,rightHand,LeftHand,Helmet,UpperBody,LowerBody }

[CreateAssetMenu(menuName = "Item")]
public class Item :ScriptableObject 

{

   public  Sprite ItemSprite;
   public  string ItemName;
   public  int ItemID;
   public  int Cost;
   public  EquipType itemType;
 
 


}
