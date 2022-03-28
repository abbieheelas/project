using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameObject abilityEffect;
    public float multiplier = 1.5f;
    public float duration = 8f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( speedBoostActive(other) );
        }
    }

    IEnumerator speedBoostActive(Collider player)
    {
        //Visual Cue
        Instantiate(abilityEffect, transform.position, transform.rotation);
        //Apply Speed Boost
        PlayerMovement move = player.GetComponent<PlayerMovement>();
        move.speed *= multiplier;
        //Remove the ability object
        Destroy(gameObject);
        //wait 8 seconds
        yield return new WaitForSeconds(duration);
        //reverse speed boost
        move.speed /= multiplier;
    }
}
