using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLizs : MonoBehaviour {
	public GameObject lizPrefab;

	IEnumerator Start () {
		float xPosition = 5;
		float yPosition = -1;

		while(true) { // TODO LINQ
			GameObject lizClone = Instantiate(this.lizPrefab) as GameObject;
			lizClone.transform.position = new Vector2(xPosition, yPosition);
			yield return new WaitForSeconds(1.0f);
		}
	}
}
