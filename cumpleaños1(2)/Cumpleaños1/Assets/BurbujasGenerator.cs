using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurbujasGenerator : MonoBehaviour {
    
    public GameObject Burbuja;

    public float generatorTime = 3f;

    void Start()
    {
        InvokeRepeating("CreateArcoirirs", 24f, generatorTime);
    }

    public void CreateArcoirirs()
    {
        Instantiate(Burbuja, transform.position, Quaternion.identity);
    }
}
