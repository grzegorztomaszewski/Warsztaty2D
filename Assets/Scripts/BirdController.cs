using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {
    public static BirdController instance = null;
    public float flapForce;
    public Rigidbody2D rb2d;    
    public float maxSpeed;
    public Animator anim;
    public bool isAlive = true;
    public float points;
    // Use this for initialization
    private void Awake()
    {
        if (BirdController.instance == null)
        {
            BirdController.instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
       // anim = GetComponent<Animator>();
       // anim.SetBool("isAlive", GameManager.instance.isAlive);
    }
    
    // Update is called once per frame
    void Update ()
    {
    //jump
    if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rb2d.AddForce(Vector2.up * flapForce);
           // anim.SetTrigger("Flap");
        }
        //Mathf.Clamp(rb2d.velocity.y, -maxSpeed, maxSpeed);

        if (rb2d == true)
        {

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pipe")
        {
            isAlive = false;
           //anim.SetBool("isAlive", GameManager.instance.isAlive);
        }
        
    }
    //dodaje punkty
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")//Pierwszy obiekt w prefabie "Pipes" posiad tag 'Point' 
        {
            points++;
            Debug.Log(points);
        }
    }
}
