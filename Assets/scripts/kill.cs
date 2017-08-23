using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {

	void OnMouseEnter(){
		Debug.Log ("10");
		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log ("11");

			GameParams.AddScore (100);

		

			BallCrate.countball -= 1;
			if (CompareTag ("mato")) {
				BallCrate.high = 11;
				Debug.Log (BallCrate.high);
				Destroy (gameObject);
			}
			if (CompareTag ("mato1")) {
				BallCrate.high = 22;
				Debug.Log (BallCrate.high);
				Destroy (gameObject);
			}
			if (CompareTag ("mato2")) {
				BallCrate.high = 33;
				Debug.Log (BallCrate.high);
				Destroy (gameObject);
			}		

		}
	}
}
