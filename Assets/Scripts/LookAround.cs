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
        transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        rotation -= y;
        rotation = Mathf.Clamp(rotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
        player.Rotate(Vector3.up * x);
    }
}
