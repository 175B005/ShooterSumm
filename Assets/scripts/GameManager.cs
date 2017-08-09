using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static string NextScene = "";
	// Use this for initialization
	void Start () {
        GameParams.SetScore(0);

	}
	
	// Update is called once per frame
	void Update () {
		//Oキー
		if (Input.GetKeyDown (KeyCode.O)) {
			NextScene = "TimeUp";
		}

     /*   //Aキー
        else if (Input.GetKeyDown(KeyCode.A)) 
        {
            GameParams.AddScore(100);
        }*/

		//シーンの切り替え処理
		if (NextScene.Length > 0){
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
	}
}