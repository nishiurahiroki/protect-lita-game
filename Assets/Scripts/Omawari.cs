using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omawari : MonoBehaviour {
	public GameObject burret;
	public GameObject fireEffect;

	void Update() {
		if(Input.GetKeyDown(KeyCode.Space)) {
			this.showShotEffect();

			if(0 == GameGlobalState.burretStock) {
				return;
			}

			this.shotBurret();
		}
	}

	private void showShotEffect() {
		var fireEffectPosition = transform.position;
		fireEffectPosition.x -= 0.5f;
		fireEffectPosition.y += 0.1f;
		Instantiate(this.fireEffect, fireEffectPosition, transform.rotation);
	}

	private void shotBurret() {
    this.gameObject.GetComponent<AudioSource>().Play();
		Instantiate(this.burret, transform.position, transform.rotation);
		GameGlobalState.burretStock--;
	}
}
