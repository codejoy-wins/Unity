using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour {


    // how do I access variables from another script??
    // by using static for the other variable and saying scriptname.staticvariable

    public Rigidbody2D rb;
    public int speed;
    private float moveInput;
    private bool facingRight;
    // jumping stuff
    public int jumpForce;
    public bool isGrounded;
    public Transform feet;
    public float checkRadius;
    // Here's what I couldn't remember:
    public LayerMask whatIsGround;

    public int extrajumps;
    public int jumpAmount;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
        isGrounded = false;
        Debug.Log(mover.xp);
	}
	
	void Update () {
        //  check a layer cast for the ground 

        isGrounded = Physics2D.OverlapCircle(feet.position, checkRadius, whatIsGround);

        // jumping

        if(Input.GetButtonDown("Jump") && isGrounded == true){
            extrajumps = jumpAmount;
            jump();
        }
        else if(Input.GetButtonDown("Jump") && isGrounded == false && extrajumps >0){
            jump();
            extrajumps--;
        }

        moveInput = Input.GetAxis("Horizontal");
        if(moveInput < 0){
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }else if(moveInput >0){
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }

        if(moveInput < 0 && facingRight == true){
            Flip();
        }else if(moveInput > 0 && facingRight == false){
            Flip();
        }
	}

    void Flip(){
        facingRight = !facingRight;
        transform.Rotate(0f,180,0f);
    }

    void jump(){
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
