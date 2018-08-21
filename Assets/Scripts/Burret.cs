using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burret : MonoBehaviour {
  public float speed = 0.1f;

  private Renderer _renderer;

  void Start () {
    this.Shot();

    this._renderer = GetComponent<Renderer>();
  }

  void Update() {
    if(!this._renderer.isVisible) {
      Destroy(this.gameObject);
    }
  }

  private void Shot() {
    Vector2 velocity;
    velocity.y = Mathf.Cos(Mathf.Deg2Rad * -150.0f) * speed;
    velocity.x = Mathf.Sin(Mathf.Deg2Rad * -30.0f) * speed;
    GetComponent<Rigidbody2D>().velocity = velocity;
  }
}
