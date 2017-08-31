using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//-startシーンに戻る-
public class ResultMGR : MonoBehaviour {

	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			SceneManager.LoadSceneAsync ("Start");
		}	
		GameParams.MaxScoreC ();
		GameParams.DrawScore ();
	

	}
}