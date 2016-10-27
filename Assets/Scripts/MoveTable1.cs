using UnityEngine;
using System.Collections;

public class MoveTable1 : MonoBehaviour {

	private int velocidad;
	float desplazamiento;
	// Use this for initialization
	void Start () {
		velocidad = 100;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector2.up * velocidad * Time.deltaTime);
		}
		else if(Input.GetKey (KeyCode.S)) {
			transform.Translate(Vector2.down * velocidad * Time.deltaTime);
		}

	
	}
}
