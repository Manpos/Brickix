using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;



public class ScoreUI : MonoBehaviour {

	public Text scoreLeftText, scoreRightText;
	private int scoreLeft, scoreRight;
    private ScoreController scoreController;

	// Use this for initialization
	void Start () {
        scoreController = GameObject.Find("GameController").GetComponent<ScoreController>();
    }
	
	// Update is called once per frame
	void Update () {
        scoreLeft = scoreController.leftScore;
        scoreRight = scoreController.rightScore;

        scoreLeftText.text = (int)scoreLeft + "";
		scoreRightText.text = (int)scoreRight + "";
	}
}
	