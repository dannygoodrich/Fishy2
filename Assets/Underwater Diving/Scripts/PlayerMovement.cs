﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
   

    public float forwardForce = 50f;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

        if ( Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.fixedDeltaTime, 0, 0);
            
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.fixedDeltaTime, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -500 * Time.fixedDeltaTime, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 500* Time.fixedDeltaTime, 0);
        }
    }
}
