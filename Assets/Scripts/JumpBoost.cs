using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public GameObject abilityEffect;
    public float multiplier = 1.5f;
    public float duration = 8f;

    void OnTriggerEnter(Collider other) //when player collides with boost, start the jump boost
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( jumpBoostActive(other) );
        }
    }

    IEnumerator jumpBoostActive(Collider player)
    {
        //Visual Cue
        Instantiate(abilityEffect, transform.position, transform.rotation);
        //Apply Jump Boost
        PlayerMovement move = player.GetComponent<PlayerMovement>();
        move.jumpHeight *= multiplier;
        //Remove the ability object
        Destroy(gameObject);
        //wait 8 seconds
        yield return new WaitForSeconds(duration);
        //reverse jump boost
        move.jumpHeight /= multiplier;
    }
}
