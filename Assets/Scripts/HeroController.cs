using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]



public class HeroController : MonoBehaviour
{
    [SerializeField] GameObject swordTest;
    [SerializeField] string heroName = "player";
    [SerializeField] string HAxisBlendParam = "H";
    [SerializeField] string VAxisBlendParam = "V";

    [Header("Weapon Sockets")]
    [SerializeField] Transform U;
    [SerializeField] Transform D;
    [SerializeField] Transform R;
    [SerializeField] Transform L;
    [SerializeField] Transform UR;
    [SerializeField] Transform UL;
    [SerializeField] Transform DR;
    [SerializeField] Transform DL;


    IController controller;
    Rigidbody2D rb2d;
    Animator animator;
    Hero myplayer;
    float speed;


    private void Awake()
    {
        EnventorySlot.setPlayerItem += SetWeapon;
    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        controller = new KeyboardController();
        animator = GetComponent<Animator>();
        myplayer = new Hero(heroName, controller, rb2d,animator);
    }

    private void Update()
    {
        myplayer.updatePlayerAnimation(HAxisBlendParam, VAxisBlendParam);
    }


    bool UPright=> controller.XYAxis.x >0&& controller.XYAxis.y>0;
    bool UPleft=> controller.XYAxis.x <0&& controller.XYAxis.y>0;
    bool Downleft=> controller.XYAxis.x <0&& controller.XYAxis.y<0;
    bool Downright=> controller.XYAxis.x >0&& controller.XYAxis.y<0;
    bool Right=> controller.XYAxis.x >0&& controller.XYAxis.y==0;
    bool Left=> controller.XYAxis.x <0&& controller.XYAxis.y==0;
    bool Up=> controller.XYAxis.x ==0&& controller.XYAxis.y>0;
    bool Down=> controller.XYAxis.x==0&& controller.XYAxis.y<0;
    bool DiagonalMovement => controller.XYAxis.x != 0 && controller.XYAxis.y != 0;

    private void FixedUpdate()
    {
        if (DiagonalMovement)//you can remove it  important. I wrote to test only..
        {
            if (true)
            {

            }
        }


        if (Right)
        {
            swordTest.transform.parent = R;
        }
        else if (Left)
        {
            swordTest.transform.parent = L;
        }
        else if (Up)
        {
            swordTest.transform.parent = U;
        }
        else if (Down)
        {
            swordTest.transform.parent = D;
        }
        else if (UPright)
        {
            swordTest.transform.parent = UR;
        }
        else if (UPleft)
        {
            swordTest.transform.parent = UL;
        }
        else if (Downright)
        {
            swordTest.transform.parent = DR;
        }
        else if (Downleft)
        {
            swordTest.transform.parent = DL;
        }

        if (controller.XYAxis.x!=0)//left right
        {
           // Debug.Log(controller.XYAxis);
            swordTest.transform.right = new Vector3(-controller.XYAxis.x * 180, -controller.XYAxis.y * 180,  90);
            swordTest.transform.localPosition= new Vector3(0.128f* controller.XYAxis.x, 0.128f * controller.XYAxis.y, 0.128f );
           

        }
        Reset(swordTest.transform);
        myplayer.move();
    }

    void Reset(Transform transform)
    {
        transform.localRotation = Quaternion.identity;
        transform.localPosition = Vector3.zero;
        transform.localScale = Vector3.one;
    }

    void SetWeapon(Sprite weaponSprite)
    {
        Debug.Log("Change sprite");

       var im= swordTest.GetComponent<SpriteRenderer>();
        im.sprite = weaponSprite;
        Debug.Log(im.name);


    }
}
