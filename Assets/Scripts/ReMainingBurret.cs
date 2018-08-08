using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReMainingBurret : MonoBehaviour {
	void Update () {
		this.GetComponent<Text>().text = GameGlobalState.remainingBurret.ToString();
	}
}
