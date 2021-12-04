using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemInfoDialog : MonoBehaviour
{
  
    [SerializeField] TextMeshProUGUI itemName_txt;
    [SerializeField] TextMeshProUGUI itemCost_txt;
    [SerializeField] TextMeshProUGUI itemType_txt;

 




    private void Awake()
    {
        EnventorySlot.ShowitemData += ShowItemTest;
        gameObject.SetActive(false);
    }

    void ShowItemTest(string itemName,string itemcost,string itemType )
    {
        this.enabled=true;
        //   transform.position = Input.mousePosition;
        itemName_txt.text= itemName;
        itemCost_txt.text = itemcost;
        itemType_txt.text = itemType;
     }

  
}
