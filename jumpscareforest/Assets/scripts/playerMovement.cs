using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float movementInput;

    private bool isGrounded;
    public Transform FeetPos;
    public float JumpForce;
    public float Radius;
    public LayerMask isGround;
    private float JumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
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

        isGrounded = Physics2D.OverlapCircle(FeetPos.position, Radius, isGround);

        if (movementInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if(movementInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * JumpForce;
            isJumping = true;
            JumpTimeCounter = jumpTime;
            Debug.Log(0);
        }

        if(Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if(JumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * JumpForce;
                JumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
            
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}
