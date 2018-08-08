using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateLizs : MonoBehaviour {
	public GameObject lizPrefab;

	IEnumerator Start () { // TODO コルーチン以外で書けないか?
		const float xCreatePosition = 5;
		const float yCreatePosition = -1;

		while(this.ExistsStock()) { // TODO LINQ
			this.lizPrefab.GetComponent<Liz>().minSpeed = GameGlobalState.lizMinSpeed;
			this.lizPrefab.GetComponent<Liz>().maxSpeed = GameGlobalState.lizMaxSpeed;
			GameObject lizClone = Instantiate(this.lizPrefab) as GameObject;
			lizClone.transform.position = new Vector2(xCreatePosition, yCreatePosition);
			yield return new WaitForSeconds(this.GetLizCreateInterval());
		}

		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene("GameClear");
	}

	private bool ExistsStock() {
		return 1 < GameGlobalState.lizStock;
	}

	private float GetLizCreateInterval() {
		return Random.Range(GameGlobalState.lizCreateIntervalFrom, GameGlobalState.lizCreateIntervalTo);
	}
}
