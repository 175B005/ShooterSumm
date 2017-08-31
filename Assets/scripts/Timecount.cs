using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//-ゲーム中のタイムオーバー-
public class Timecount : MonoBehaviour {

	private int Tim =0;
	public static float c =60;
	public static Timecount instance;
	public Text TimeText;

	void Update () {
		Tim += 1;
		if (Tim >= 30) {
			Tim = 0;
			c -= 0.5f;
			DrawTime ();
			//Debug.Log (c);

			if (c <= 0) {
				GameManager.PlaySE(3);
				SceneManager.LoadScene ("TimeUp");
			}
		}
	}
	void Awake(){
		//インスタンスいthisを与える
		instance = this;
		//初期化設定
		//、、、しないとc=６０が残って、すぐ終了するｗ
		Tim = 0;
		c = 60;
	}
	
	public static void DrawTime(){
		if(instance.TimeText != null) {
			instance.TimeText.text = "Time " + c.ToString ();
		}

	}
}