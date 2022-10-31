using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : character
{
    void Start()
    {

    }
    // Update is called once per frame
    protected override void FixedUpdate()
    {
        //delta reset and sprite swap for movement
       
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        moveDelta = new Vector3(x, y, 0);
        base.animate.SetFloat("Horizontal", moveDelta.x);
        base.animate.SetFloat("Vertical", moveDelta.y);
        base.animate.SetFloat("Speed", moveDelta.sqrMagnitude);
        base.FixedUpdate();
    }
}

