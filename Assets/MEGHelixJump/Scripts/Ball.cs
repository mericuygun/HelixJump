using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpForce);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Ad�: " + materialName);

        if(materialName == "Safe Colour") 
        { 
            destroy.
        }

    }

    private DestroyBall()


}
