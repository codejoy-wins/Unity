using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mover : MonoBehaviour {


    public Rigidbody2D rb;
    public int speed;
    public bool movingRight;
    public bool movingUp;
    public int left;
    public int right;
    public int up;
    public int down;

    public int health = 100;

    public static int xp = 18;
	// Use this for initialization
	void Start () {
        health = 1000;
        rb = GetComponent<Rigidbody2D>();
        movingRight = true;
        movingUp = true;
	}
    // enemy taking hits
    public void TakeDamage(int damage){
        health -= damage;

        if(health <= 0){
            die();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (movingRight == true){
            rb.velocity = new Vector2(5, rb.velocity.y);
        }else if(movingRight == false){
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        if(movingUp == true){
            rb.velocity = new Vector3(rb.velocity.x, .6f);
        }else if(movingUp == false){
            rb.velocity = new Vector2(rb.velocity.x, -1f);
        }


        if (transform.position.x < left){
            movingRight = true;
        }
        if (transform.position.x > right){
            movingRight = false;
        }
        if (transform.position.y < down)
        {
            movingUp = true;
        }
        else if (transform.position.y > up)
        {
            movingUp = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "circle"){
            SceneManager.LoadScene("SampleScene");
        }
    }

    void die(){
        Destroy(gameObject);
    }

}
