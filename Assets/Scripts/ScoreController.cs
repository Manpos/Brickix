using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

    public int leftScore;
    public int rightScore;
    private int maxScore;

	// Use this for initialization
	void Start () {
        leftScore = 0;
        rightScore = 0;
        maxScore = 6;
    }

    public void leftGoals() { leftScore++; }
    public void rightGoals() { leftScore++; }

    bool maxScoreIsReached(){
        if (leftScore == maxScore || rightScore == maxScore) {
            return true;
        }
        else return false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
