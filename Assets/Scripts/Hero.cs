using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
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
        heroAnimator.updateMode = AnimatorUpdateMode.AnimatePhysics;
        this.maxSpeed = maxSpeed;

    }
    //
 
    public void updatePlayerAnimation(string hBlendAxisname,string vBlendAxisName)//string hAxis,string vAxis
    {
       
        if (controller.XYAxis.x!=0|| controller.XYAxis.y != 0)
        {
            
            heroAnimator.SetFloat(Animator.StringToHash(hBlendAxisname), controller.XYAxis.x);
            heroAnimator.SetFloat(Animator.StringToHash(vBlendAxisName), controller.XYAxis.y);
            heroAnimator.speed = 1;
        }
        else
        {
            heroAnimator.speed = 0;
        }

    }
    public void move(float Customspeed=0)
    {
        maxSpeed = Customspeed > 0 ? Customspeed : maxSpeed;
        physicsBody.velocity = controller.XYAxis * maxSpeed;
    }






}
