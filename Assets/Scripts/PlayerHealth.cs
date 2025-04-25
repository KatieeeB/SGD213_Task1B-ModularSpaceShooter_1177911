using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    [SerializeField]
    protected int currentHealth;
    public int CurrentHealth { get { return currentHealth; } }

    [SerializeField]
    protected int maxHealth;
    public int MaxHealth { get { return maxHealth; } }

    void Start()
    {
        currentHealth = maxHealth; //set the players currentHealth to maxHealth at start of game.
    }

    // <summary>
    /// Heal handles the functionality of receiving health
    /// </summary>
    /// <param name="healingAmount">The amount of health to gain, this value should be positive</param>
    public void Heal(int healingAmount)
    {
        currentHealth += healingAmount; //add healingAmount to currentHealth

        if (currentHealth > maxHealth) //if current health exceeds MaxHealth set it to the max.
        {
            currentHealth = maxHealth;
        }

        UIManager.instance.UpdatePlayerHealthSlider((float)currentHealth / (float)maxHealth); //update player health bar

    }

    /// <summary>
    /// TakeDamage handles the functionality for taking damage
    /// </summary>
    /// <param name="damageAmount">The amount of damage to lose, this value should be positive</param>
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; //take damageAmount from currentHealth

        UIManager.instance.UpdatePlayerHealthSlider((float)currentHealth / (float)maxHealth); //update player health bar

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    /// <summary>
    /// Handles all functionality related to when health reaches or goes below zero, should perform all necessary cleanup.
    /// </summary>
    public void Die()
    {
        // would be good to do some death animation here maybe
        // remove this object from the game
        Destroy(gameObject);
    }
}
