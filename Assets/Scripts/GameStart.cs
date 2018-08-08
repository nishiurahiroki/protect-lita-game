using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
	public float maxSpeed;
	public float minSpeed;
	public int lizStock;
	public int remainingBurret;
	public float lizCreateIntervalTo;
	public float lizCreateIntervalFrom;

	public void OnClick () {
		GameGlobalState.lizStock = this.lizStock;
		GameGlobalState.lizMaxSpeed = this.maxSpeed;
		GameGlobalState.lizMinSpeed = this.minSpeed;
		GameGlobalState.lizCreateIntervalTo = this.lizCreateIntervalTo;
		GameGlobalState.lizCreateIntervalFrom = this.lizCreateIntervalFrom;
		GameGlobalState.remainingBurret = this.remainingBurret;

		SceneManager.LoadScene("Main");
	}
}
