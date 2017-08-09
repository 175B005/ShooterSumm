using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager: MonoBehaviour {
    void Start()
    {
        GameParams.DrawScore();
    }


	void Update () {
		if (Input.GetButtonDown("Fire1")){	
			SceneManager.LoadSceneAsync ("Play");
	}
}
}