using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour {
    public GameObject Gift1;
    public GameObject Feliz;
    public GameObject Codigo1;


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Gift1.GetComponent<Animator>().Play("Gift");

            Feliz.SetActive(true);
            Codigo1.SetActive(true);
         
        }
    }

}
