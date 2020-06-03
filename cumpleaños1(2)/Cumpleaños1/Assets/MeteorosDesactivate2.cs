using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorosDesactivate2 : MonoBehaviour {


    public GameObject Meteoro1;
    public GameObject Meteoro2;
    public GameObject Meteoro3;
    public GameObject Meteoro4;
    public GameObject Meteoro5;
    public GameObject Meteoro6;
    public GameObject Meteoro7;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
        
        //Meteoro1.SetActive(false);
               Meteoro2.SetActive(false);
            //Meteoro3.SetActive(false);
             Meteoro4.SetActive(false);
            //Meteoro5.SetActive(false);
             Meteoro6.SetActive(false);
            //Meteoro7.SetActive(false);
        }
    }
}
