using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//-シーン切り替えとゲーム中の音楽を再生-
public class GameManager : MonoBehaviour {
	public GameObject prefmato;

	public static string NextScene = "";

	//効果音
	public static AudioSource[] SE;
	public  AudioClip[] SEAudio;
	private static GameManager instance;

	public static void PlaySE(int num){
		
		SE[num].Play();
	}

	void Start () {

		SE = gameObject.GetComponents<AudioSource> ();
        GameParams.SetScore(0);
		//PlaySE (5);　Play On AwakeでやっているからOK。
	}
	void Update () {
	/*	//Oキー
		if (Input.GetKeyDown (KeyCode.O)) {
			PlaySE (0);
			Time.timeScale = 0;
			//時間ではなく繰り返しで動くので
			//時間をとめても動き続ける,物理挙動ではないw
			NextScene = "TimeUp";
		}
		*/
		//シーンの切り替え処理
		if (NextScene.Length > 0){
		//	SE[5].Stop();
		SceneManager.LoadSceneAsync (NextScene, LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
	}
}