using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; 
    public float speed = 2.5f;  //how fast you go
    bool isGrounded;
    public float jumpHeight = 0.75f; //how high jump is
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;  
    public Vector3 velocity = Vector3.zero; 
    
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //jump = new Vector3(0f, 0.90f, 0f);
    }


    // Update is called once per frame. 
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);  //checks if player is on ground by using a small radius on the floor
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;               //ensures jump height stays constant
        }

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 moveX = transform.right * x;
        Vector3 moveZ = transform.forward * z;
        Vector3 xzCombined = (moveX + moveZ).normalized * speed;
        controller.Move(xzCombined * speed * Time.deltaTime); //allows the player to move forward, backward, left and right

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.fixedDeltaTime); 
    }
}
