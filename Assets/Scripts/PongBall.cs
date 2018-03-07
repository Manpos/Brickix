using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour {

    public Rigidbody2D pongBall;

	// Use this for initialization
	void Start () {
        pongBall = this.GetComponent<Rigidbody2D>();
        int rand = Random.Range(0, 2);
        if (rand == 0)
        {
           pongBall.velocity = new Vector2(-2f, 0f);
        }
        else if (rand == 1)
        {
            pongBall.velocity = new Vector2(2f, 0f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
