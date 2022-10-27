using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject crackPrefab;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.velocity = new Vector3(0, jumpForce, 0);

        GameObject crack = Instantiate(crackPrefab, transform.position + new Vector3(0f, -0.242f, 0f), transform.rotation);
        crack.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Adý: " + materialName);

        if(materialName == "Safe Colour (Instance)") 
        { 
            //destroy.
        }
        else if(materialName == "Unsafe Colour (Instance)")
        {
            Debug.Log("Game Over!");
        }
        else if(materialName == "Last Ring (Instance)")
        {
            Debug.Log("Finish!");
        }

    }

    

}
