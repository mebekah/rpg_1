﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Resources;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;
       // moveSpeed
    }
}
