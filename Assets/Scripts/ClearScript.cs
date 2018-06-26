using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScript : MonoBehaviour {

	static public int score;
	Text Scoretext;

	// Use this for initialization
	void Start () {
		
		Scoretext = GameObject.Find("Canvas/Score").GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {

		Scoretext.text = "クリアまで：" + score+"個";

		if (score == 0) {
			Application.LoadLevel ("GameClear");
		}
	}
}
