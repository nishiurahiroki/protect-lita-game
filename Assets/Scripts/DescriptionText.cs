using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionText : MonoBehaviour {
  public float blinkInterval = 1.0f;

  void Start() {
    StartCoroutine("Blink");
  }

  IEnumerator Blink() {
    while(true) {
      this.GetComponent<Text>().enabled = !this.GetComponent<Text>().enabled;
      yield return new WaitForSeconds(this.blinkInterval);
    }
  }
}
