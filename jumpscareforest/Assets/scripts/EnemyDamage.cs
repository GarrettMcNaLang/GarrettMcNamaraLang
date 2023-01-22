using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //lets the damage script know where to find the player health script
    public playerHealth PlayerHealth;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //This function is called whenever something enters the enemy collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //calls the playerHealth script
            PlayerHealth.TakeDamage(damage);
        }
    }
}
