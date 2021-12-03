using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]



public class HeroController : MonoBehaviour
{
    [SerializeField] string heroName = "player";
    [SerializeField] string HAxisBlendParam = "H";
    [SerializeField] string VAxisBlendParam = "V";
    float speed;

    IController controller;
    Rigidbody2D rb2d;
    Animator animator;
    Hero myplayer;
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
    private void FixedUpdate()
    {
        myplayer.move();
    }

}
