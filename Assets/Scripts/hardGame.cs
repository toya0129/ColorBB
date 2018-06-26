using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardGame : MonoBehaviour {

	public void onClickToGameH(){
		ClearScript.score = 14;
		Application.LoadLevel ("stage01");
	}
}
