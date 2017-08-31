using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-邪魔板を制御-
public class jammer : MonoBehaviour {

	public float vel = -0.01f;
	void Update () {
		if (transform.position.x <= -1.3f
		   || transform.position.x >= 1.3f) {
			vel = -vel;
		}

		transform.position += new Vector3 (vel, 0f, 0f);
	}
}
