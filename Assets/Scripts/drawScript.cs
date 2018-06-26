using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drawScript : MonoBehaviour {

	Text ScoreTimetext;

	// Use this for initialization
	void Start () {
		ScoreTimetext = GameObject.Find("Canvas/ScoreTime").GetComponent<Text> ();
		ScoreTimetext.text = "クリア時間：" + TimerScript.min+":"+TimerScript.sec;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
