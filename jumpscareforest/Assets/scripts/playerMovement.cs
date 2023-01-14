using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float movementInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movementInput * speed, rb.velocity.y);
    }
}
