using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//-startシーンに戻る-
public class ResultMGR : MonoBehaviour {

	void Start(){
		//GameManager.PlaySE (2);

		GameParams.MaxScoreC ();
		GameParams.DrawScore ();

	}
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			SceneManager.LoadSceneAsync ("Start");
		}	

	}
}