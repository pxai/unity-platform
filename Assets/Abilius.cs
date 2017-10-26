using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilius : MonoBehaviour {
    private int speed = 8;
    private int toTheLeft = -1;
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
        int jumping = (state == JUMPING) ? 1 : 0;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (toTheLeft != -1) { turn(); }
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-1, jumping) * 2;
  
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (toTheLeft == -1) { turn(); }
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(1, jumping) * 2;
   
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (state != JUMPING)
            {
                previousState = state;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;
                state = JUMPING;
            }
        }

        this.transform.rotation = Quaternion.identity;
    }

    public void turn() {
        toTheLeft = toTheLeft * -1;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    public void jumpEnded() {
        state = STOPPED;
        previousState = JUMPING;
    }
}
