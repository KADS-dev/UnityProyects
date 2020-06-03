using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour {
    public GameObject Meteoro0;
    public float velocityMeteoro0 = 3f;
    private Rigidbody2D rb2d;
    void Start () {
       
        Meteoro0 = GetComponent<GameObject>();
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.down * velocityMeteoro0;
        Das();
    }

    void Das()
    {
        if (Meteoro0 != null)
        {
            rb2d.position = Meteoro0.transform.position;
        }

    }
    
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MeteoroDestroyer")
        {
            Destroy(gameObject);
        }
    }
}
