using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCurse : MonoBehaviour
{
    public GameObject abilityEffect;
    public float multiplier = 1.5f;
    public float duration = 8f;

    void OnTriggerEnter(Collider other) //when player collides with curse, start the speed curse
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( speedCurseActive(other) );
        }
    }

    IEnumerator speedCurseActive(Collider player)
    {
        //Visual Cue
        Instantiate(abilityEffect, transform.position, transform.rotation);
        //Apply Speed Curse
        PlayerMovement move = player.GetComponent<PlayerMovement>();
        move.speed /= multiplier;
        //Remove the curse object
        Destroy(gameObject);
        //wait 8 seconds
        yield return new WaitForSeconds(duration);
        //reverse speed curse
        move.jumpHeight *= multiplier;
    }
}
