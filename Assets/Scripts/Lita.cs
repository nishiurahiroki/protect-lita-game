using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lita : MonoBehaviour {
  void OnTriggerEnter2D(Collider2D colliderObject) {
    if("liz_big(Clone)".Equals(colliderObject.name)) {
      SceneManager.LoadScene("GameOver");
    }
  }
}
