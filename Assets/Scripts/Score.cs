using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;



public class Score : MonoBehaviour {

	public Text scoreLeftText, scoreRightText;
	private int scoreLeft, scoreRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreLeftText.text = (int)scoreLeft + "";
		scoreRightText.text = (int)scoreRight + "";
	}
}
	