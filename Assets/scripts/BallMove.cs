using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallMove : MonoBehaviour {

	void Update(){
		if (CompareTag ("mato")) {
			transform.position += new Vector3 (-0.04f, 0f, 0f);
			if (transform.position.x <= -4.56f) {
				BallCrate.countball -= 1;
				Debug.Log (BallCrate.countball);
				BallCrate.high = 11;
				Debug.Log (BallCrate.high);
				Destroy (gameObject);
			}
		}
		if (CompareTag ("mato1")) {
			transform.position += new Vector3 (-0.06f, 0f, 0f);
			if (transform.position.x <= -3.51f) {
				BallCrate.countball -= 1;
				Debug.Log (BallCrate.countball);
				BallCrate.high = 22;
				Debug.Log (BallCrate.high);
				Destroy (gameObject);

			}
		}
		if (CompareTag ("mato2")) {
			transform.position += new Vector3 (-0.05f, 0f, 0f);
			if (transform.position.x <= -2.56f) {
				BallCrate.countball -= 1;
				Debug.Log (BallCrate.countball);
				BallCrate.high = 33;
				Debug.Log (BallCrate.high);
				Destroy (gameObject);
			}
		}


	}
	}