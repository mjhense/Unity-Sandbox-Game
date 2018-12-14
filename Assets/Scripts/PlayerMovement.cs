using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
            GetComponent<Animator>().SetBool("down", true);
        else if (Input.GetKeyUp(KeyCode.S))
            GetComponent<Animator>().SetBool("down", false);
        else if (Input.GetKeyDown(KeyCode.A))
            GetComponent<Animator>().SetBool("left", true);
        else if (Input.GetKeyUp(KeyCode.A))
            GetComponent<Animator>().SetBool("left", false);
        else if (Input.GetKeyDown(KeyCode.D))
            GetComponent<Animator>().SetBool("right", true);
        else if (Input.GetKeyUp(KeyCode.D))
            GetComponent<Animator>().SetBool("right", false);
        else if (Input.GetKeyDown(KeyCode.W))
            GetComponent<Animator>().SetBool("up", true);
        else if (Input.GetKeyUp(KeyCode.W))
            GetComponent<Animator>().SetBool("up", false);

        if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody2D>().transform.Translate(-speed, 0, 0);
        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody2D>().transform.Translate(0, -speed, 0);
        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody2D>().transform.Translate(speed, 0, 0);
        if (Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody2D>().transform.Translate(0, speed, 0);
    }
}
