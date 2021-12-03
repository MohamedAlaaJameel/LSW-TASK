using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero
{

    IController controller;


    Rigidbody2D physicsBody;
    Animator heroAnimator;
    string name;
    float maxSpeed;

    bool isDied;
    int status;
 
 

    public Hero(string name, IController controller, Rigidbody2D physicsBody, Animator heroAnimator,float maxSpeed=2f)
    {
        this.name = name;
        this.controller = controller;
        this.physicsBody = physicsBody;
        this.heroAnimator = heroAnimator;
        this.maxSpeed = maxSpeed;

    }

    public void updatePlayerAnimation()
    {
        heroAnimator.SetFloat("H", controller.XYAxis.x);
        heroAnimator.SetFloat("V", controller.XYAxis.y);
    }
    public void move(float Customspeed=0)
    {
        maxSpeed = Customspeed > 0 ? Customspeed : maxSpeed;
        physicsBody.velocity = controller.XYAxis * maxSpeed;
    }






}
