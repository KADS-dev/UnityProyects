using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStop : MonoBehaviour
{
    public GameObject Canvas;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Canvas.GetComponent<Animator>().Play("CanvasMove3");
        }
    }
}
