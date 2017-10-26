using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilius : MonoBehaviour {
    private int speed = 8;
    private const int STOPPED = 0;
    private const int RUNNING = 1;
    private const int JUMPING = 2;
    private const int SHOOTING = 3;

    private int state = STOPPED;
    private int previousState = STOPPED;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (state != JUMPING)
            {
                previousState = state;
                this.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
                state = JUMPING;
            }
        }
        Debug.Log("Update " + state + "," + previousState);
        this.transform.rotation = Quaternion.identity;
    }

    public void jumpEnded() {
        state = previousState;
        previousState = JUMPING;
    }
}
