﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeUpMGR : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			SceneManager.LoadSceneAsync ("Result");
		}
	}
}
