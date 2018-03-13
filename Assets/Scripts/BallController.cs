using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody2D RB;
    private float ballVelocity = 2f;
    private ScoreController scoreController;
    private float hitOffset = 10f;

    // Use this for initialization
    void Start () {
        RB = GetComponent<Rigidbody2D>();

        int xDirection = Random.Range(0, 2);
        float yDirection = Random.value;
        float launchDirectionX = ballVelocity;
        if (xDirection == 0) { launchDirectionX = -ballVelocity; }
        if (xDirection == 1) { launchDirectionX = ballVelocity; }

        scoreController = GameObject.Find("GameController").GetComponent<ScoreController>();

        RB.velocity = new Vector3(launchDirectionX, yDirection, 0f);
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(RB.velocity);
	}

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Boundaries"){
            RB.velocity = new Vector2(RB.velocity.x, RB.velocity.y);
            //RB.velocity = new Vector2((RB.velocity.normalized).x * ballVelocity, -((RB.velocity.normalized).y * ballVelocity));
            Debug.Log("Fuck");
        }
        /*if (collision.gameObject.tag == "BoundariesBottom")
        {
            RB.velocity = new Vector3((RB.velocity.normalized).x * ballVelocity, (RB.velocity.normalized).y * ballVelocity * -1f, 0f);
        }*/

        if (collision.gameObject.tag == "PlayerLeft"){
            float dist = this.transform.position.y - GameObject.Find("PlayerLeft").transform.position.y;
            /*if (collision.contacts.Length > 0) {
                Vector2 variation = collision.contacts[0].point - collision.gameObject.transform.position;
                variation.Normalize();
            }*/
            RB.velocity = new Vector2(ballVelocity, dist * hitOffset);
            
        }
        if (collision.gameObject.tag == "PlayerRight")
        {
            float dist = this.transform.position.y - GameObject.Find("PlayerRight").transform.position.y;
            RB.velocity = new Vector2(-ballVelocity, dist * hitOffset);
        }
        Debug.Log(collision.gameObject.tag);
        /*if (collision.gameObject.tag == "Brick")
        {
            RB.velocity = new Vector3((RB.velocity.normalized).x * ballVelocity * -1f, (RB.velocity.normalized).y * ballVelocity, 0f);
        }*/

        if (collision.gameObject.tag == "GoalLeft"){ scoreController.leftScore++; }
        if (collision.gameObject.tag == "GoalRight"){ scoreController.rightScore++; }
    } 
}
