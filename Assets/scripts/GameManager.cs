using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public GameObject prefmato;

	public static string NextScene = "";

	void Start () {
        GameParams.SetScore(0);

	}
	void Update () {

		//Oキー
		if (Input.GetKeyDown (KeyCode.O)) {
			Time.timeScale = 0;
			NextScene = "TimeUp";

		}

		//シーンの切り替え処理
		if (NextScene.Length > 0){
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
	}
}