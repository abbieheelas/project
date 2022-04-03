using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badMovement : MonoBehaviour
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

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(moveSideways * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-moveSideways * Time.deltaTime, 0, 0);
        }
        //if(Input.GetKey("space"))
       // {
        //    rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        //}
    }
}
