using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Text pointsText;
    public bool isAlive = true;
    public static GameManager instance = null;
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
	void Update () {
        pointsText.text = "" + pointsText;
	}
}
