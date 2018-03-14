using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BRICK_TYPE { HARD = 3, MID = 2, SOFT = 1};
public enum DIRECTION { UP = 1, DOWN = -1};

public class Brick : MonoBehaviour {
    public BRICK_TYPE type;
    public DIRECTION dir;
    SpriteRenderer sprite;
    BoxCollider2D boxCollider;
	// Use this for initialization
	void Start () {
        boxCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        type = (BRICK_TYPE)Mathf.FloorToInt(Random.Range(1f, 4f));

        switch (type)
        {
            case BRICK_TYPE.HARD:
                sprite.color = Color.green;
                break;
            case BRICK_TYPE.MID:
                sprite.color = Color.yellow;
                break;
            case BRICK_TYPE.SOFT:
                sprite.color = Color.red;
                break;
            default:
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, (float)dir * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int newType = (int)type-1;

        if (newType > 0)
        {
            switch ((BRICK_TYPE)newType)
            {
                case BRICK_TYPE.MID:
                    sprite.color = Color.yellow;
                    type = (BRICK_TYPE)newType;
                    break;
                case BRICK_TYPE.SOFT:
                    sprite.color = Color.red;
                    type = (BRICK_TYPE)newType;
                    break;
            }
        }
        else
        {
            boxCollider.isTrigger = true;
            sprite.enabled = false;
        }
        
    }

}
