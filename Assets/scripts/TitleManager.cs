using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//-ｸﾘｯｸされると即ゲームスタート！-
public class TitleManager: MonoBehaviour {
    void Start()
    {
		//GameManager.PlaySE (0);
        GameParams.DrawScore();
    }
		
	void Update () {
		if (Input.GetButtonDown("Fire1")){	
			//GameManager.PlaySE (1);
				SceneManager.LoadSceneAsync ("Play");
	}
}
}