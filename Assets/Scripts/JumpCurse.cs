using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCurse : MonoBehaviour
{
    public GameObject abilityEffect;
    public float multiplier = 1.5f;
    public float duration = 8f;

    void OnTriggerEnter(Collider other) //when player collides with curse, start the jump curse
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( jumpCurseActive(other) );
        }
    }

    IEnumerator jumpCurseActive(Collider player)
    {
        //Visual Cue
        Instantiate(abilityEffect, transform.position, transform.rotation);
        //Apply jump curse
        PlayerMovement move = player.GetComponent<PlayerMovement>();
        move.jumpHeight /= multiplier;
        //Remove the curse object
        Destroy(gameObject);
        //wait 8 seconds
        yield return new WaitForSeconds(duration);
        //reverse jump curse
        move.jumpHeight *= multiplier;
    }
}
