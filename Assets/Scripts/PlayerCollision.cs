using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public LookAround look;

    void OnCollisionEnter (UnityEngine.Collision collisioninfo)
    {
        if (collisioninfo.gameObject.tag == "obstacle")
        {
            Debug.Log("hit log");
            movement.enabled = false; //turns off movement script
            look.enabled = false;
            FindObjectOfType<GameManager>().GameOver(); //accesses the gameover method in the gamemanager file
        }
    }
}
