using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStars : MonoBehaviour {
    public GameObject Pista;
    public GameObject Star;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

   
    public GameObject Star6;
    public GameObject Star7;
    public GameObject Star8;
    public GameObject Star9;
    public GameObject Star10;

    public GameObject MusicNyan;

    public NyanController NyanScript;

    public GameObject Canvas;
    
    // Use this for initialization
    void Start () {
        NyanScript = GameObject.Find("NyanCat1").GetComponent<NyanController>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
        
      

            Star6.SetActive(true);
            Star7.SetActive(true);
            Star8.SetActive(true);
            Star9.SetActive(true);
            Star10.SetActive(true);
            NyanScript.enabled = true;
            MusicNyan.SetActive(true);
            Canvas.GetComponent<Animator>().Play("CanvasMove");
            Pista.SetActive(false);
        }

    }

}
