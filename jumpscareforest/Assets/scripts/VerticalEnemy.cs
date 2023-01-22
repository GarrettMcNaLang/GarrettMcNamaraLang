using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemy : MonoBehaviour
{
    public float speed;
    public float range;

    float startingY;
    //used to reverse direction
    private int dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        //transforms on the y coordinate
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //moves the enemy up
        transform.Translate(Vector2.up * speed * Time.deltaTime * dir);
        //checks if the enemy reaches the limits and moves in other direction
        if (transform.position.y < startingY || transform.position.y > startingY + range)
        {
            //changes direction by returning the direciton back to 1
            dir *= -1;
        }
    }
}
