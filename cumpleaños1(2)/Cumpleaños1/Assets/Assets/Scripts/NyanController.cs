using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyanController : MonoBehaviour {
    public float speed = 5f;
    Vector3 target;



    public ArcoirisGenerator arcoirisgenerator;
    public float izquierda = -.09f;
    public float derecha = .09f;
    public float arriba = .0f;
    public float abajo = -.0f;
    // Use this for initialization
    void Start () {
        target = transform.position;
	}
   
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = 0f;    
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);





        if (Input.GetKey(KeyCode.LeftArrow) )
        {
            this.transform.position += new Vector3(izquierda, 0f, 0f);
           
        }
        if (Input.GetKey(KeyCode.RightArrow))  
        {
            this.transform.position += new Vector3(derecha, 0f, 0f);
          
        }
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            this.transform.position += new Vector3(0, arriba, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += new Vector3(0, abajo, 0f);
        }
        
    }
        
        private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Meteoro")
        {
            Destroy(gameObject);

        }
        if (other.gameObject.tag == "Techo")
        {
            arriba = 0f;
        
        } 
        if (other.gameObject.tag == "Piso")
        {
            abajo = 0f;
        }
        if (other.gameObject.tag == "ParedDerecha")
        {
            derecha = 0f;
        }
        if (other.gameObject.tag == "ParedIzquierda")
        {
            izquierda = 0f;
        }
        if (other.gameObject.tag == "SafeZone")
        {
            abajo = -0.1f;
            arriba = 0.1f;
            derecha = 0.1f;
            izquierda = -0.1f;
        }

    }

}
