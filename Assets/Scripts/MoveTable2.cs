using UnityEngine;
using System.Collections;

public class MoveTable2 : MonoBehaviour {

	private int velocidad;
	
	// Use this for initialization
	void Start () {
		velocidad = 100;
		
	}
	
	// Update is called once per frame
	void Update () {
		float desplazamiento = 0.0f;
		desplazamiento = Input.GetAxis ("Vertical") * velocidad * Time.deltaTime;
		transform.Translate(Vector2.up * desplazamiento);
		
	}
}
