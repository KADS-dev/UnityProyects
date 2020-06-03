using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateStars : MonoBehaviour {

    public GameObject Star;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public GameObject Star4;
    public GameObject Star5;
    public GameObject Star6;
    public GameObject Star7;
    public GameObject Star8;
    public GameObject Star9;
    public GameObject Star10;

    public GameObject Star13;
    public GameObject Star14;
    public GameObject Star15;
    public GameObject Star16;
    public GameObject Star17;
    public GameObject Star18;
    public GameObject Star19;
    public GameObject Star20;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Star.SetActive(false);
            Star1.SetActive(false);
            Star2.SetActive(false);
            Star3.SetActive(false);
            Star4.SetActive(false);
            Star5.SetActive(false);
            Star6.SetActive(false);
            Star7.SetActive(false);
            Star8.SetActive(false);
            Star9.SetActive(false);
            Star10.SetActive(false);

            Star13.SetActive(true);
            Star14.SetActive(true);
            Star15.SetActive(true);
            Star16.SetActive(true);
            Star17.SetActive(true);
            Star18.SetActive(true);
            Star19.SetActive(true);
            Star20.SetActive(true);

        }

    }
}
