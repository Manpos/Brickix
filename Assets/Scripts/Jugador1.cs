using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour {

    public GameObject pala;
    // Use this for initialization
    Vector3 moveup = new Vector3(0, 0.1f, 0);

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            pala.transform.Translate(moveup);
        }

        if (Input.GetKey(KeyCode.S))
        {
            pala.transform.Translate(-moveup);
        }
    }
}
