using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    //public GameManager gameManager;

    void OnTriggerEnter() //when player makes contact with object
    {
        FindObjectOfType<GameManager>().CompleteLevel(); //accesses completelevel method from gamemanager file
    }
}
