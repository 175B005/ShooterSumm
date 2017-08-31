using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//-TimeUp表示後リザルトに切り替え-
public class TimeUpMGR : MonoBehaviour {
	private int tim = 0;

	void Update () {

		tim += 1;
		if(tim >= 100){
		//if (Input.GetButtonDown ("Fire1")) {
		//	GameManager.NextScene = "Result";
			SceneManager.LoadScene ("Result");
		//		GameManager.NextScene = "";
				enabled = false;
		//	}
		}
		}
	}

