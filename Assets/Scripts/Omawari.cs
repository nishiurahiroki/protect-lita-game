using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omawari : MonoBehaviour {
	public GameObject burret;

	void Update() {
		if(Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(this.burret, transform.position, transform.rotation);
		}
	}
}
