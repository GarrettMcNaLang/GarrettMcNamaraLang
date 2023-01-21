using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //the character
    public GameObject Target;
    //how much distance the character can move freely before our camera starts moving
    public Vector2 Offset;
    //defined boundary box
    private Vector2 threshold;
    //defines how fast the camera moves
    public float speed;
    //reference to Rigibody
    private Rigidbody2D rb;

     void Start()
    {
        //defines threshold
        threshold = calculateThreshold();
        rb = Target.GetComponent<Rigidbody2D>();

    }

    void LateUpdate()
    {
        //define the distance the file object is from the center of the camera
        Vector2 follow = Target.transform.position;
        //keeps track of the distance the player is from the center of the x-axis
        float xDifference = Vector2.Distance(Vector2.right * transform.position.x, Vector2.right * follow.x);
        float yDifference = Vector2.Distance(Vector2.up * transform.position.y, Vector2.up * follow.y);

        //camera will remain where currently is
        Vector3 newPosition = transform.position;
        if(Mathf.Abs(xDifference) >= threshold.x)
        {
            newPosition.x = follow.x;
        }
        if(Mathf.Abs(yDifference) >= threshold.y)
        {
            newPosition.y = follow.y;
        }
        //determines speed of barrier if the player speed exceeds said barrier; if true it goes max velocity, if false it goes the default speed
        float moveSpeed = rb.velocity.magnitude > speed ? rb.velocity.magnitude : speed;
        //makes it so the camera will move towards this position each frame
        transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);
        
    }
    //formula that calculates threshold
    private Vector3 calculateThreshold()
    {
        //defines aspect ratio of camera
        Rect aspect = Camera.main.pixelRect;
        //defines dimensions of camera
        Vector2 t = new Vector2(Camera.main.orthographicSize * aspect.width / aspect.height, Camera.main.orthographicSize);
        //defines threshold(subtract boundary box value by offset value)
        t.x -= Offset.x;
        t.y -= Offset.y;
        return t;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector2 border = calculateThreshold();
        Gizmos.DrawWireCube(transform.position, new Vector3(border.x * 2, border.y * 2, 1));
    }
}
