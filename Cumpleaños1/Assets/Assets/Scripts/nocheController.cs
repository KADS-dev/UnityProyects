using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nocheController : MonoBehaviour {
    private float velocitya = 1.2f;
   public GameObject Noche;
   Rigidbody2D rb2dd;
	// Use this for initialization
	void Start () {
        Noche = GetComponent<GameObject>();
        rb2dd = GetComponent<Rigidbody2D>();
        rb2dd.velocity = Vector2.left * velocitya;
        Dass();
	}


   void Dass()
    {
        if (Noche != null)
        {
            rb2dd.position = Noche.transform.position;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
