using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroGenerator : MonoBehaviour {
    public GameObject MeteoroPref;
    public float generatorTime = 3.0f;
    // Use this for initialization
    void Start()
    {
        MeteoroPref.transform.TransformVector(0f, -10f, 0f);
        InvokeRepeating("CreateArcoirirs", 0f, generatorTime);

    }

    // Update is called once per frame
    void Update() {

    }
    public void CreateArcoirirs()
    {
        Instantiate(MeteoroPref, transform.position, Quaternion.identity);
    }
    
        
}
