﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lita : MonoBehaviour {
	void OnTriggerEnter2D() {
		SceneManager.LoadScene("GameOver");
	}
}
