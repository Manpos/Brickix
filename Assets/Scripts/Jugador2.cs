using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2 : MonoBehaviour {

    public GameObject pala;
    // Use this for initialization
    Vector3 moveup = new Vector3(0, 0.1f, 0);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pala.transform.Translate(moveup);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            pala.transform.Translate(-moveup);
        }
    }
}
