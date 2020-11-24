using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 300f;
    public float slowForwardForce = 30f;
    public float sideWaysForce = 300f;
    public bool is_jumping;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("hello world this is debug");
    }

// when player collide in ground
    // private void OnCollisionEnter(Collision other) {
    //     var obj = other.collider;
    //     if (obj.tag == "ground") {
    //         Debug.Log("hit ground");
    //             is_jumping = false;
    //         }else{
    //         Debug.Log("not hit ground");
    //             is_jumping = true;
    //         }
    // }

    // Update is called once per frame
    void FixedUpdate()//use fixed update when deal with something related to game physics
    {
        //move forward automatic
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        // if(Input.GetKey("space") && is_jumping == false){
        //     rb.AddForce(0, 50f * Time.deltaTime, 0, ForceMode.VelocityChange);
        // }
        if(Input.GetKey("d")){
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-(sideWaysForce) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1){
            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}
