using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burret : MonoBehaviour {
	public float speed = 0.1f;

	void Start () {
		Vector2 velocity;
		velocity.y = Mathf.Cos(Mathf.Deg2Rad * -150.0f) * speed;
		velocity.x = Mathf.Sin(Mathf.Deg2Rad * -30.0f) * speed;

		GetComponent<Rigidbody2D>().velocity = velocity;
	}

	void OnBecameInvisible() {
		Destroy(this.gameObject);
	}
}
