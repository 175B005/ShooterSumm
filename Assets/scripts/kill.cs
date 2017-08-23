using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {

	void OnMouseEnter(){
		//Debug.Log ("10");
		if (Input.GetButtonDown ("Fire1")) {
	//		Debug.Log ("11");

			GameParams.AddScore (100);
		
			BallCrate.countball -= 1;
			if (CompareTag ("mato")) {
				Destroy (gameObject);
			}
			if (CompareTag ("mato1")) {
				Destroy (gameObject);
			}
			if (CompareTag ("mato2")) {
				Destroy (gameObject);
			}	


			if (BallCrate.high != 33) {
				BallCrate.high += 11;
			} else {
				BallCrate.high = 11;
			}
			Debug.Log (BallCrate.high);

		}
	}
}
