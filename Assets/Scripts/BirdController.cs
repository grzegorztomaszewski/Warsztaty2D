﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public float flapForce;
    public Rigidbody2D rb2d;
	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
    //jump
	if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * flapForce);
        }
    }
}
