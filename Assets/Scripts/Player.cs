using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject pala;
    // Use this for initialization
    Vector3 moveup = new Vector3(0, 0.07f, 0);
    
    public bool player1 = true;
    
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (player1)
        {
            if (Input.GetKey(KeyCode.W) && pala.transform.position.y < 1.47)
            {
                pala.transform.Translate(moveup);
            }

            if (Input.GetKey(KeyCode.S) && pala.transform.position.y > -1.47)
            {
                pala.transform.Translate(-moveup);
            }
        }      
        
        else
        {
            if (Input.GetKey(KeyCode.UpArrow) && pala.transform.position.y < 1.47)
            {
                pala.transform.Translate(moveup);
            }

            if (Input.GetKey(KeyCode.DownArrow) && pala.transform.position.y > -1.47)
            {
                pala.transform.Translate(-moveup);
            }
        }
        
    }
}
