using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float sensitivity = 10f;
    public Transform player;
    public float rotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.localRotation = Quaternion.Euler(0f, 0f, 0f); //player starts facing the front
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime; //value for virtual Y+X axis via mouse input,  
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime; //multiplied by sens and time determined by frame rate
        rotation -= y;                                                      
        rotation = Mathf.Clamp(rotation, -90f, 90f); //if the rotation is between -90 and 90, then the player can rotate
        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f); //rotation about z axis determined by mouse movement
        player.Rotate(Vector3.up * x); 
    }
}
