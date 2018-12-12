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
    public static float points; //punkty

    public AudioClip audioFlap; //audio flap'a
    public AudioClip audioPoint; //audio point'a
    public AudioClip audioHit; //audio hita w pipe'a
    public AudioClip audioDead; //audio dead'a po uderzeniu w pipe'a
    public AudioSource audioSource; //źródło dźwięku podpięte pod birda


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
       anim = GetComponent<Animator>();
       anim.SetBool("isAlive", GameManager.instance.isAlive);
       audioSource = GetComponent<AudioSource> ();
    }
    
    // Update is called once per frame
    void Update ()
    {
    //jump
    if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rb2d.AddForce(Vector2.up * flapForce);
            audioSource.PlayOneShot(audioFlap); //dźwięk wzlotu
           // anim.SetTrigger("Flap");            //animacja lotu
        }
        //Mathf.Clamp(rb2d.velocity.y, -maxSpeed, maxSpeed);

        if (rb2d == true)
        {

        }

    }
    //kolizja z pipe'm uśmierca Bird'a
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pipe")
        {
            audioSource.PlayOneShot(audioHit); // dźwięk hita w pipe'a
            isAlive = false;
           // audioSource.PlayOneShot(audioDead); // dźwięk dead'a po uderzeniu w pipe'a 
          // anim.SetBool("isAlive", GameManager.instance.isAlive);
        }
        
    }

    //dodaje punkty
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point" && isAlive)//Pierwszy obiekt w prefabie "Pipes" posiada tag 'Point' 
        {
            points++;
            audioSource.PlayOneShot(audioPoint); //dźwięk zdobycia punktu
        }
    }
}
