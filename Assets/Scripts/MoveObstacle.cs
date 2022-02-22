using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    Vector3 startPosition;
    public float speed = 2f;
    public float distance = 2f;
    public float height = 2f;
    public float width = 2f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = startPosition + transform.right * Mathf.Sin(Time.time * speed * Time.deltaTime) * distance + transform.up * -Math.Abs(Mathf.Cos(Time.time * speed * Time.deltaTime) * height) + transform.forward * Mathf.Sin(Time.time * speed * Time.deltaTime) * width;
    }
}
