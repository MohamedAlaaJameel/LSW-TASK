using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]

public class NPCHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string shopKeepername="Steven";
    [SerializeField] string dialogMSG="hello here is shopkeeper";

    NPC shopkeeper;
    void Start()
    {
        shopkeeper = new ShopKeeper(this.transform,shopKeepername, dialogMSG);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
