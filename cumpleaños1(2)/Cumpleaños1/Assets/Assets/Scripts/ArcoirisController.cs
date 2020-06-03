using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcoirisController : MonoBehaviour
{

    public float velocityArcoiris = 0.3653f;
    private Rigidbody2D rb2d;
    public GameObject NyanBody;
   
    // Use this for initialization
    void Start()
    {

        NyanBody = GetComponent<GameObject>();
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.left * velocityArcoiris *6;
        Das();


    }

    void Das()
    {
        if (NyanBody  != null)
        {
            rb2d.position = NyanBody.transform.position;
        }
        
    }   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }
    }      
}