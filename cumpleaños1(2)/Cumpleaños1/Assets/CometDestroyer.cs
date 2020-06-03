using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometDestroyer : MonoBehaviour {
    public GameObject Comet;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Destroyer")
        {

            Destroy(Comet);
          
        }
    }
}
