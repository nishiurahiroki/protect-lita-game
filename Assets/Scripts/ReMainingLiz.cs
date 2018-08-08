using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReMainingLiz : MonoBehaviour {
	void Update () {
		this.GetComponent<Text>().text = GameGlobalState.lizStock.ToString();
	}
}
