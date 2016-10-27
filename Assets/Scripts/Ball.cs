using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public int velocidad;
	public float desviacion;

	// Use this for initialization
	void Start () {
		velocidad = 100;
		desviacion = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (velocidad * Time.deltaTime * Mathf.Cos(desviacion), velocidad * Time.deltaTime * Mathf.Sin(desviacion), 0);
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.GetComponent<CollisionTable> () != null) {
			this.desviacion += Mathf.PI / 4;
		}
		if (other.GetComponent<CollisionWall> () != null) {
			this.desviacion -= Mathf.PI / 2;
		}

	}
}
