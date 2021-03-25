using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolespetites : MonoBehaviour
{
    private Rigidbody rb;
   
    void Start()
    {
         rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(1,0,1);

        rb.AddForce(vel);
    }
}
