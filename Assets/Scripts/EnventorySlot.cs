using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnventorySlot : MonoBehaviour
{

    Sprite itemSprite;

    public delegate void myDelegate(Sprite itemsprite);
    public delegate void InfoDelegate(string text);
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
    private void BTNClick()
    {
        Debug.Log(itemSprite.name);
       
        setPlayerItem.Invoke(itemSprite);
    }


    static Sprite lastShownSprite; 
    public void ShowItemInfo()
    {
 
       
       
          var infoPanel = bag.InfoPanel;
          infoPanel.SetActive(true);
          foreach (var elemnt in bag.items)
          {
              if (itemSprite==elemnt.ItemSprite&& itemSprite != lastShownSprite)
              {
         
       
                  lastShownSprite = itemSprite;
                  ShowitemData.Invoke(
                     
                      $"- {elemnt.ItemName}"+
                       $"\n"+
       
                       $"-{elemnt.Cost}" +
                        $"\n" +
                        $"-{elemnt.itemType}"
       
                      );
                  Debug.Log(elemnt.ItemName);
                  break;
              }
          }
        
       
        //  setPlayerItem.Invoke(itemSprite);
       
       
    }

    float lastTimeCalled = 0.0f;

    public void HideInfoDialog()
    {
        if (lastTimeCalled > 0.0f)
        {
            var infoPanel = bag.InfoPanel;
            infoPanel.SetActive(false);

            lastTimeCalled = Time.realtimeSinceStartup;
        }
    }
    // Start is called before the first frame update

}
