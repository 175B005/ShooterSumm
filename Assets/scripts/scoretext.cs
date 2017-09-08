using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoretext : MonoBehaviour {
	
	public static scoretext instance;
	public Text scorePt;

	void Awake(){
		instance = this;
	}

	public static void TextCreate(int n){
		Quaternion qua = new Quaternion ();
		qua = Quaternion.identity;

		Vector3 mmpos = Input.mousePosition;
		mmpos.y = mmpos.y + 30;

		if (instance.scorePt != null) {
			instance.scorePt.text = "" + n.ToString ();
			Instantiate (instance.scorePt, mmpos, qua);
		}

	}

}
