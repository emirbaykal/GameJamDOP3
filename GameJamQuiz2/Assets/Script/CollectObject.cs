using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    private int astronaut;
    private int ingot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ast" +astronaut);
        Debug.Log("ingot"+ingot);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("astronaut"))
        {
            astronaut += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("ingot"))
        {
            ingot += 1;
            Destroy(other.gameObject);
        }
    }
}
