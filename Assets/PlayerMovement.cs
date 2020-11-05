using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideWaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("hello world this is debug");
    }

    // Update is called once per frame
    void FixedUpdate()//use fixed update when deal with something related to game physics
    {
        if(Input.GetKey("w")){
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("s")){
            rb.AddForce(0, 0, -(forwardForce) * Time.deltaTime);
        }
        if(Input.GetKey("d")){
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-(sideWaysForce) * Time.deltaTime, 0, 0);
        }
    }
}
