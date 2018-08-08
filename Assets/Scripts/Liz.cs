using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liz : MonoBehaviour {
	public float minSpeed = 2.0f;
	public float maxSpeed = 7.0f;

	void Start () {
		this.MoveToLita();
	}

	private void MoveToLita() {
		float moveSpeed = Random.Range(this.minSpeed, this.maxSpeed);

		const float xMoveMoment = -1;
		const float yMoveMoment = 0;

		Vector2 direction = new Vector2(xMoveMoment, yMoveMoment).normalized;
		GetComponent<Rigidbody2D>().velocity = direction * moveSpeed;
	}

	void OnBecameInvisible() {
		Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D colliderObject) {
		if("burret".Equals(colliderObject.name)) {
			GameGlobalState.lizStock--;

			Destroy(colliderObject.gameObject);
			Destroy(this.gameObject);
		}
	}
}
