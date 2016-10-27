using UnityEngine;
using System.Collections;

public class StayScenary : MonoBehaviour {

	void OnTriggerExit2D(Collider2D other){
		if (other.GetComponent<Ball> () != null) {
			Debug.Log("Salio");
		}
	}
}
