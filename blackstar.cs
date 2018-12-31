using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class blackStar : MonoBehaviour {

    // Use this for initialization

    // Update is called once per frame


    void Update () {
        if (transform.position.y < 57){
            //Debug.Log("GAME WON");
            SceneManager.LoadScene("SampleScene");
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "circle"){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
