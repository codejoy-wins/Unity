using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blackHole : MonoBehaviour {

    public float timer;

	// Use this for initialization
	void Start () {
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer > 1.7){
            Destroy(gameObject);
        }
        // deal damage
        // have things rotate around it
        // let player use black hole as a slingshot
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet"){
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "black"){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
