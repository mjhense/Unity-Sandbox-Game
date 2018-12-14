using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class RandomMovement : MonoBehaviour {
    System.Random rand;
    float timer = 0.0f;
    private int direction;
    [SerializeField]
    private float speed;

	// Use this for initialization
	void Start () {
        rand = new System.Random((int)new System.Random().Next(1,10000000));
        
	}

    // Update is called once per frame
    void Update()
    {
            timer += Time.deltaTime;
            if (timer > 3.0f)
            {
                timer = 0.0f;
                direction = rand.Next(1, 5);
            }

        if (direction == 1)
            GetComponent<Animator>().SetBool("down", true);
        if (direction != 1)
            GetComponent<Animator>().SetBool("down", false);
        if (direction == 4)
            GetComponent<Animator>().SetBool("left", true);
        if (direction != 4)
            GetComponent<Animator>().SetBool("left", false);
        if (direction == 2)
            GetComponent<Animator>().SetBool("right", true);
        if (direction != 2)
            GetComponent<Animator>().SetBool("right", false);
        if (direction == 3)
            GetComponent<Animator>().SetBool("up", true);
        if (direction != 3)
            GetComponent<Animator>().SetBool("up", false);

        if (direction == 4)
            GetComponent<Rigidbody2D>().transform.Translate(-speed, 0, 0);
        else if (direction == 1)
            GetComponent<Rigidbody2D>().transform.Translate(0, -speed, 0);
        else if (direction == 2)
            GetComponent<Rigidbody2D>().transform.Translate(speed, 0, 0);
        else if (direction == 3)
            GetComponent<Rigidbody2D>().transform.Translate(0, speed, 0);
    }
}
