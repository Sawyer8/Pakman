﻿using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //add a forward force


        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
           if (Input.GetKey("w"))
         {
              rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);

          }
         if (Input.GetKey("s"))
          {
               rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);

         }
    }
}

