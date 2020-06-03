using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorosDesactivate5y6 : MonoBehaviour {


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

            Destroy(Meteoro1);
            Destroy(Meteoro2);
            Destroy(Meteoro3);
            Destroy(Meteoro4);
            Destroy(Meteoro5);
            Destroy(Meteoro6);
            Destroy(Meteoro7);
        }
    }
}
