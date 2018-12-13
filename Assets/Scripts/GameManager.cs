using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : BirdController{
	
	//public bool isAlive = true;
	new public static GameManager instance = null;
    public Text pointsText; //punkty jako tekst

    // Use this for initialization
    private void Awake()
	{
		if (GameManager.instance == null)
		{
			GameManager.instance = this;
		}
		else
		{
			Destroy(this.gameObject);
		}
	}
		void Start ()
		{

		}
	
	
	// Update is called once per frame
	void Update ()
	{
      pointsText.text = "" + points; // wyświetla liczbe pkt jako tekst
    }
}
