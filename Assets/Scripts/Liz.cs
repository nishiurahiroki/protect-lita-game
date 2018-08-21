using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liz : MonoBehaviour {
  public float minSpeed = 2.0f;
  public float maxSpeed = 7.0f;

  private bool isHitBurret = false;

  void Start () {
    this.MoveToLita();
  }

  private void MoveToLita() {
    float moveSpeed = Random.Range(this.minSpeed, this.maxSpeed);
    const float xMoveMoment = -1;
    const float yMoveMoment = 0;

    this.Move(moveSpeed, xMoveMoment, yMoveMoment);
  }

  private void MoveToOutOfScreen() {
    const float moveSpeed = 8.0f;
    const float xMoveMoment = -1;
    const float yMoveMoment = 50;

    this.Move(moveSpeed, xMoveMoment, yMoveMoment);
  }

  private void Move(float speed, float xMoveMoment, float yMoveMoment) {
    Vector2 direction = new Vector2(xMoveMoment, yMoveMoment).normalized;
    GetComponent<Rigidbody2D>().velocity = direction * speed;
  }

  void OnBecameInvisible() {
    Destroy(this.gameObject);
  }

  void OnTriggerEnter2D(Collider2D colliderObject) {
    if("burret".Equals(colliderObject.name)) {
      this.isHitBurret = true;

      this.MoveToOutOfScreen();
      Destroy(colliderObject.gameObject);
      Destroy(this.gameObject.GetComponent<BoxCollider2D>());
    }
  }

  void Update() {
    if(this.isHitBurret) {
      this.transform.Rotate(new Vector3(20.0f, 30.0f, 10.0f));
      this.transform.localScale = new Vector2(0.4f, 0.4f);
    }
  }
}
