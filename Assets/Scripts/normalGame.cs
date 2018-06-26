using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalGame : MonoBehaviour {

	public void onClickToGameN(){
		ClearScript.score = 8;
		Application.LoadLevel ("stage01");
	}
}
