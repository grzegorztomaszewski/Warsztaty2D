using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	//Moving pipes from right to left side
		
        if(GameManager.instance.isAlive)
        {
            transform.Translate(Vector3.left * speed);
        }
	}
}
