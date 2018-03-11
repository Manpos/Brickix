using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    Rigidbody RB;
    public float ballVelocity = 1f;

	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody>();

        int xDirection = Random.Range(0, 2);
        float yDirection = Random.value;
        float launchDirectionX = ballVelocity;
        if (xDirection == 0) { launchDirectionX = -ballVelocity; }
        if (xDirection == 1) { launchDirectionX = ballVelocity; }

        RB.velocity = new Vector3(launchDirectionX, yDirection, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boundaries"){
            RB.velocity = new Vector3(RB.velocity.x, RB.velocity.y * -1f, 0f);
        }

        if (collision.gameObject.tag == "Players"){
            RB.velocity = new Vector3(RB.velocity.x * -1f, RB.velocity.y, 0f);
        }
    } 
}
