using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	float time;
	static public int min;
	static public int sec;
	Text Timetext;


	// Use this for initialization
	void Start () {

		time = 0;
		Timetext = GameObject.Find("Canvas/Time").GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		time+=Time.deltaTime;

		min = (int)time / 60;
		sec = (int)time % 60;

		Timetext.text = "タイム：" + min +":"+ sec;
	}
}
