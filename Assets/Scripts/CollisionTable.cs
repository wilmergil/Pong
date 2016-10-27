using UnityEngine;
using System.Collections;

public class CollisionTable : MonoBehaviour {
	

	void OnTriggerEnter2D(Collider2D other){
		if (other.GetComponent<Ball> () != null) {
			other.GetComponent<Ball>().velocidad *= -1;
		}
	}

	/*void OnCollisionEnter2D(Collision2D other){
		if (other.collider.GetComponent<Ball> () != null) {
			other.collider.GetComponent<Ball>().velocidad *= -1;
		}
	}*/

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
