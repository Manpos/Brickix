using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksSpawner : MonoBehaviour {
    public GameObject brickPrefab;
    public BoxCollider2D destroyer;
    public float maxTime;
    private float timeBetweenBricks = 0;
    private bool flipFlop = false;
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

        // Check time between two blocks
        if (flipFlop)
        {
            timeBetweenBricks += Time.deltaTime;
        }
        else if(!flipFlop && timeBetweenBricks > 0)
        {
            if ((Mathf.Floor(timeBetweenBricks * 10f)/10f) > maxTime)
            {
                brickLine.Enqueue(new GameObject());
            }
            Debug.Log(timeBetweenBricks);
            timeBetweenBricks = 0;
        }

        // Spawns blocks every x time
        if (timer <= 0 && brickLine.Count > 0)
        {
            GameObject brick = Instantiate(brickLine.Dequeue());
            brick.transform.position = transform.position;
            timer = maxTime;
        }
        else if(brickLine.Count < 0 && timeBetweenBricks != 0f)
        {
            timer = maxTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            flipFlop = !flipFlop;
            brickLine.Enqueue(collision.gameObject);
            DestroyObject(collision.gameObject, 10f);
        }
    }
}
