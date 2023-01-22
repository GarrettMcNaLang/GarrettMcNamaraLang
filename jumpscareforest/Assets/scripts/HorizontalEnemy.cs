using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEnemy : MonoBehaviour
{
    //speed of platform
    public float speed;
    //starting index(position of the platform)
    public int startingPoint;
    //points where the platform needs to move to
    public Transform[] points;
    //index of points
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        //sets the position of the platform to the position of one of the points using
        //index "startingpoint"
        transform.position = points[startingPoint].position;
    }

    // Update is called once per frame
    void Update()
    {
        //checking the distance of the platform and the point
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            //increases the index
            i++;
            //checks if the platform was on the first point after the index increase
            if (i == points.Length)
            {
                //reset the index
                i = 0;
            }
        }
        //moving the platform to the point with the position "i"
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
