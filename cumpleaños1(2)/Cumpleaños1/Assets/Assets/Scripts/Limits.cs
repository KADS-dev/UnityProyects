using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Limits : MonoBehaviour {

    private Transform theTransfomr;
    public Vector2 Hrange = Vector2.zero;
    public Vector2 Vrange = Vector2.zero;
    // Use this for initialization
    void Start () {
        theTransfomr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LateUpdate()
    {
        theTransfomr.position = new Vector3(
    Mathf.Clamp(transform.position.x, Vrange.x, Vrange.y),
    Mathf.Clamp(transform.position.x, Hrange.x, Hrange.y),
    transform.position.z
    ); 
    }
}
