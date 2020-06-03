using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcoirisGenerator : MonoBehaviour {
    public GameObject arcoirisPrefab;

    public float generatorTime = 0.03333334f;
   
    void Start()
    {
        InvokeRepeating("CreateArcoirirs", 0f, generatorTime);
    }
     
    public void CreateArcoirirs()
    {
        Instantiate(arcoirisPrefab, transform.position, Quaternion.identity);
    }
    public void StartGenerator()
    {
        
    }
    void Update()
    {
       
    }


}

