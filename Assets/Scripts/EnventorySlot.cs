using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnventorySlot : MonoBehaviour
{

    Sprite itemSprite;

    public delegate void myDelegate(Sprite itemsprite);
    public delegate void InfoDelegate(string name,string cost,string type);
    public static InfoDelegate ShowitemData;
    public  static myDelegate setPlayerItem;

    ShopBag bag;

    private void Awake()
    {
          bag = GetComponentInParent<ShopBag>();
    }
    private void Start()
    {
        itemSprite = GetComponent<Image>().sprite;
    }
    public void SetPlayerItem()//called by unity .
    {
        setPlayerItem.Invoke(itemSprite);
    }


     public void ShowItemInfo()
    {
 
       
       
    
          foreach (var elemnt in bag.items)
          {
              if (itemSprite==elemnt.ItemSprite&& itemSprite)
              {
         
       
                
                  ShowitemData.Invoke($"{elemnt.ItemName}" , $"{elemnt.Cost}", $"{elemnt.itemType}");
                  Debug.Log(elemnt.ItemName);
                  break;
              }
          }
        
       
        
       
    }
  
     
 
}
