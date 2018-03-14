using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksSpawner : MonoBehaviour {
    public GameObject brickPrefab;
    public BoxCollider2D destroyer;
    public DIRECTION dir;
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

        // Spawns blocks every x time
        if (timer <= 0 && brickLine.Count > 0)
        {
            GameObject brick = Instantiate(brickLine.Dequeue());
            brick.transform.position = transform.position;
            brick.GetComponent<Brick>().dir = dir;
            timer = maxTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            brickLine.Enqueue(collision.gameObject);
            DestroyObject(collision.gameObject, 10f);
        }
    }
}
