using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemInfoDialog : MonoBehaviour
{
  
    [SerializeField] TextMeshProUGUI TMPElemnt;

 




    private void Awake()
    {
        EnventorySlot.ShowitemData += ShowItemTest;
    }

    void ShowItemTest(string texts )
    {
        this.enabled=true;
        transform.position = Input.mousePosition;
        TMPElemnt.text=texts;
    }

  
}
