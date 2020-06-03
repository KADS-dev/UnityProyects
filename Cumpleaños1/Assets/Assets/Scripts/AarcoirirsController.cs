using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AarcoirirsController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-.09f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(.09f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0f, .09f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += new Vector3(0, -.09f, 0f);
        }

    }

}
