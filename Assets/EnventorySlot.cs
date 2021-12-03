using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnventorySlot : MonoBehaviour
{

    Sprite itemSprite;
    private void Start()
    {
   
    }

    public delegate void myDelegate(Sprite itemsprite);
    public  static myDelegate setPlayerItem;
    private void BTNClick()
    {
        itemSprite = GetComponent<Image>().sprite;
        Debug.Log(itemSprite.name);
       
        setPlayerItem.Invoke(itemSprite);
    }
 
    // Start is called before the first frame update

}
