using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
    public Rigidbody2D rb2d;
    public float flapForce;
	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	 if (Input.GetKeyDown(KeyCode.Space))
		{
            rb2d.AddForce(Vector2.up * flapForce);
        }
	}
}
