using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoFriend1Dialogue : MonoBehaviour {

    public GameObject text;
    public GameObject whyText;

    void Start() {
        //text = GameObject.Find("Dino1Text");
        //Debug.Log("Should be turned off.");
        //text.SetActive(false);
        //text.GetComponent<MeshRenderer>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
            Instantiate(text);
        //pop up dialogue box
        //text.GetComponent<MeshRenderer>().enabled = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //text.GetComponent<MeshRenderer>().enabled = false;
        if(other.tag == "Player")
            Destroy(GameObject.FindGameObjectWithTag("text1"));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player") {
            Destroy(GameObject.FindGameObjectWithTag("text1"));
            Instantiate(whyText);
        }
    }
}