using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField]
    private int healingAmount;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject player = col.gameObject;
            HandlePlayerPickup(player);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject player = col.gameObject;
            HandlePlayerPickup(player);
        }
    }

 private void HandlePlayerPickup(GameObject player)
    {
          // get the playerHealth from the player
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        // handle a case where the player doesnt have a PlayerHealth
        if (playerHealth == null) 
        {
            Debug.LogError("Player doesn't have a PlayerHealth component.");
            return;
        } 
        else 
        {
            // Heal the player
            playerHealth.Heal(healingAmount);
        }
    }


}
