using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burbujas : MonoBehaviour
{

   
        public GameObject Burbuja;
        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.tag == "BurbujasDestroyer")
            {

                Destroy(Burbuja);

            }
        }
    }
