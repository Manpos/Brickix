using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksSpawner : MonoBehaviour {
    public GameObject brickPrefab;
    public BoxCollider destroyer;
    public float maxTime;
    private float timer;
    Queue<GameObject> brickLine;
    // Use this for initialization
    void Start () {
        timer = maxTime;
        brickLine = new Queue<GameObject>();
        for (int i = 0; i < 10; i++) {
            brickLine.Enqueue(brickPrefab);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer - Time.deltaTime;
        if(timer <= 0 && brickLine.Count > 0)
        {
            GameObject brick = Instantiate(brickLine.Dequeue());
            brick.transform.position = transform.position;
            timer = maxTime;
        }
        else if(brickLine.Count < 0)
        {
            timer = maxTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Brick")
        {
            brickLine.Enqueue(other.gameObject);
            //Destroy(other.gameObject);
            DestroyObject(other.gameObject, 10f);
        }
    }
}
