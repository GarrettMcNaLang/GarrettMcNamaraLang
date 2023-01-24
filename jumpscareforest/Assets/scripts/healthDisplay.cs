using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Gives the script access to UI functions

public class healthDisplay : MonoBehaviour
{
    public int health; //Player's current health
    public int maxHealth; //Player's health when full
    //Creates a box in Unity to store our empty and full heart sprites
    public Sprite emptylife;
    public Sprite fulllife;
    public Image[] lives;
    public playerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //makes sure the Health and MaxHealth match the playerhealth script
        health = playerHealth.health;
        maxHealth = playerHealth.maxHealth;
        //for loop runs for each life in the list
        //creates an integer equal to however many lives you put into your list
        //lets the enemy damage script know where to find the playerhealth script
        for (int i = 0; i < lives.Length; i++)
        {
            //this for loop will check to see if each heart is full or empty
            if(i < health)
            {
                lives[i].sprite = fulllife;
            }
            else
            {
                lives[i].sprite = emptylife;
            }
            if(i < maxHealth)
            {
                //checks each heart to see if it should be turned on
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }
        }
    }
}
