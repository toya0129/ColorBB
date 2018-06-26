using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {


	void OnCollisionEnter(Collision collision){
		
		if (collision.gameObject.GetComponent<MeshRenderer>().material.color == gameObject.GetComponent<MeshRenderer>().material.color) {
			Destroy (gameObject);
			ClearScript.score--;
		
		}

	}

}
