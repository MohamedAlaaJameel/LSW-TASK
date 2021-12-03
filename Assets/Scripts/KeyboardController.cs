using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : IController
{
    
    public float VerticalAxis => Input.GetAxisRaw("Vertical");

    public float HorzAxis => Input.GetAxisRaw("Horizontal");

    public Vector2 XYAxis => new Vector2(HorzAxis, VerticalAxis);
}
