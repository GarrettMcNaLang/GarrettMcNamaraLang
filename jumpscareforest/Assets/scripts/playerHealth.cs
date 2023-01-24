
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int health; //Keeps track of current player's health
    //How much health you have when you are at full health
    public int maxHealth = 10;
    public playerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth; //sets health to max health
    }

    public void TakeDamage(int amount) //The function will be called anytime player takes damage
                                       //amount = how much damage the player takes
    {
        health -= amount; //subtracts amount of damage from health
        if(health <= 0)   //If the damage takes the player down to zero(or below) then the player will be destroyed
        {
            playerMovement.enabled = false;
        }   
    }
}
