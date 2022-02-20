using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody rb;
    public float pressTime = 0.3f;
    public float jumpHeight = 2.0f;
    float jumpTime;
    bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            jumping = true;
            jumpTime = 0;
        }
        if (jumping)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight);
            jumpTime += Time.deltaTime;
        }
        if(Input.GetKey("space") | jumpTime > pressTime)
        {
            jumping = false;
        }
    }
}
