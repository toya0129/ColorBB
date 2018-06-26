using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public float speed;
	public Material[] colors;
	int hit;


	// Use this for initialization
	void Start () {
		
		GetComponent<Rigidbody>().AddForce((transform.right-transform.up)*speed,ForceMode.VelocityChange);
		hit = 0;

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().velocity = GetComponent<Rigidbody> ().velocity.normalized * speed;
	}

	void OnCollisionEnter(Collision collision){

		hit++;

		if (hit == 20) {
			Invoke ("ColorChange", 0.5f);
		}

		if (gameObject.GetComponent<MeshRenderer> ().material.color==collision.gameObject.GetComponent<MeshRenderer> ().material.color) {

			Invoke ("ColorChange",0.5f);

		}
	}

	void ColorChange(){

		int i;

		i = Random.Range (0, 5);

		transform.gameObject.GetComponent<Renderer> ().material = colors [i];
		hit = 0;

	}
}

