using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ShopBag : MonoBehaviour
{
   
    [SerializeField] public  Sprite[]  items = new Sprite[9];
    static int maxBag = 9;

    IEnumerable<Image> shopSlots = new Image[maxBag];

    void Start()
    {
        gameObject.SetActive(false);
         shopSlots = GetComponentsInChildren<Image>().Where(item=>item.transform!=this.transform);
        if (shopSlots.IsAny())
        {
            for (int i = 0; i < items.Length; i++)
            {
                shopSlots.ElementAt(i).sprite = items[i];
            }
        }
        
         
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
