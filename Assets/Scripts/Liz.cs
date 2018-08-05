using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liz : MonoBehaviour {
	public float speed = 5;

	void Start () {
		float xMoveMoment = -1;
		float yMoveMoment = 0;

		Vector2 direction = new Vector2(xMoveMoment, yMoveMoment).normalized;
		GetComponent<Rigidbody2D>().velocity = direction * speed;
	}

	void OnBecameInvisible() {
		Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D col) {
		Destroy(col.gameObject);
		Destroy(this.gameObject);
	}
}
