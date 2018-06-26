using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easyGame : MonoBehaviour {

	public void onClickToGameE(){
		ClearScript.score = 4;
		Application.LoadLevel ("stage01");
	}
}
