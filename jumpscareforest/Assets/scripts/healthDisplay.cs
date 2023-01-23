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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
