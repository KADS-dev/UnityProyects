using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelfinDestroyer : MonoBehaviour {
    public GameObject Delfin;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            Destroy(Delfin);

        }
    }
    }
