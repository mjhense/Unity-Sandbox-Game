using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownRoutine : MonoBehaviour {

    public enum Routine_States
    {
        Get_Water,
        Wandering,
        Returning_to_House,
        Converse,
        Get_Lumber,
        Get_Supplies,
        Fleeing,
        Dead
    }

    public Routine_States state;
    private float timer = 0.0f;
    public int direction = 0;
    public System.Random rand;
    public float speed = 0.1f;
    public float WanderDuration = 3.0f;

	// Use this for initialization
	void Start () {
        state = Routine_States.Wandering;
        rand = new System.Random((int)new System.Random().Next(1, 10000000));
    }
	
	// Update is called once per frame
	void Update () {
        switch (state)
        {
            case Routine_States.Wandering:
                RandomMovement();
                break;
        }
	}

    #region State Functions
    public void RandomMovement()
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
    #endregion
}
