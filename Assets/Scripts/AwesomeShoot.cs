using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwesomeShoot : MonoBehaviour {

    private Rigidbody2D rb;
    public bool Player1, Player2;
    public float maxBalls = 5;
    public GameObject spawner;
    public Rigidbody2D ball;
   
    int counter = 0;
	// Use this for initialization
    

  
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        /*if (Player1)
            rb.velocity = new Vector2(2, 0);
        if(Player2)
            rb.velocity = new Vector2(-2, 0);
         
 */    

    }
    public void createPlanet()
    {
        if (Player1 && Input.GetKeyDown(KeyCode.X) && counter < 5)
        {
            ball.velocity = new Vector2(-2, 0);

            Instantiate(ball, spawner.transform.position, Quaternion.identity);
            counter++;

           // Instantiate(ball, fire.position, Quaternion.identity);

        }

        if (Player2 && Input.GetKeyDown(KeyCode.Space) && counter < 5)
        {
            ball.velocity = new Vector2(-2, 0);

            Instantiate(ball, spawner.transform.position, Quaternion.identity);
            counter++;

        }

    }
    // Update is called once per frame
    void Update () {
        //Debug.Log(spawner.transform.position.y);
        
        createPlanet();

	}
}
