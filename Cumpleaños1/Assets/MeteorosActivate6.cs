using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorosActivate6 : MonoBehaviour {
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
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            //Meteoro1.SetActive(true);
            Meteoro2.SetActive(true);
            Meteoro3.SetActive(true);
            //Meteoro4.SetActive(true);
             Meteoro5.SetActive(true);
            Meteoro6.SetActive(true);
            //Meteoro7.SetActive(true);
        }
    }
}
