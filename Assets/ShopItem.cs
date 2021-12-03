using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LayoutElement))]
[RequireComponent(typeof(BoxCollider2D))]

public class ShopItem : MonoBehaviour
{

 
    SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = 10;
    }

    private void OnMouseDown()
    {
     //   Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
