using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidTilemap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game Over! points: ");
        if (collision.gameObject.name == "abilius")
        {
            collision.gameObject.GetComponent<Abilius>().jumpEnded();
   
        }
    }
}
