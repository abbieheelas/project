using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float moveSideways = 500f;
    public Vector3 jump; 
    public bool isGrounded;
    public float jumpHeight = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 2f, 0f);
    }

    void CollisionOn()
    {
        isGrounded = true;
    }
    // Update is called once per frame. FixedUpdate used to mess with physics
    void FixedUpdate()
    {
        //rb.AddForce(0,jumpHeight*Time.deltaTime,0);
        //rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        if(Input.GetKey("d")) //move to the right
        {
            rb.AddForce(moveSideways*Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")) //move to the left
        {
            rb.AddForce(-moveSideways*Time.deltaTime, 0, 0);
        }    
        if(Input.GetKey("space") && isGrounded) //jump
        {
            rb.AddForce(jump * jumpHeight, ForceMode.Impulse);
            isGrounded = false;
        }             
    }
}
