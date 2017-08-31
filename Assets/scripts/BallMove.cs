using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//-ボールを１ずつ移動（自然に消える）するスクリプト-
public class BallMove : MonoBehaviour {

	void Update(){

				if (CompareTag ("mato")) {
					transform.position += new Vector3 (-0.03f, 0f, 0f);
					if (transform.position.x <= -4.56f) {
						BallCrate.countball -= 1;
					//	Debug.Log (BallCrate.countball);
						BallCrate.high = 11;
					//	Debug.Log (BallCrate.high);
						GameParams.DeScore (1);
						Destroy (gameObject);
					}
				}
				if (CompareTag ("mato1")) {
					transform.position += new Vector3 (-0.04f, 0f, 0f);
					if (transform.position.x <= -3.51f) {
						BallCrate.countball -= 1;
					//	Debug.Log (BallCrate.countball);
						BallCrate.high = 22;
					//	Debug.Log (BallCrate.high);
						GameParams.DeScore (1);
						Destroy (gameObject);

					}
				}
				if (CompareTag ("mato2")) {
					transform.position += new Vector3 (-0.03f, 0f, 0f);
					if (transform.position.x <= -2.56f) {
						BallCrate.countball -= 1;
					//	Debug.Log (BallCrate.countball);
						BallCrate.high = 33;
					//	Debug.Log (BallCrate.high);
						GameParams.DeScore (10);
						Destroy (gameObject);
					}
				}

		}
	}