using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateLizs : MonoBehaviour {
  public GameObject lizPrefab;

  IEnumerator Start () { // TODO LINQで書ける?
    const float xCreatePosition = 5.0f;
    const float yCreatePosition = -1.3f;

    while(this.ExistsStock()) {
      int createdLizCount = this.Create(xCreatePosition, yCreatePosition);
      GameGlobalState.lizStock -= createdLizCount;
      yield return new WaitForSeconds(this.GetLizCreateInterval());
    }

    yield return new WaitForSeconds(3.5f);
    SceneManager.LoadScene("GameClear");
  }

  private int Create(float xCreatePosition, float yCreatePosition) {
    this.lizPrefab.GetComponent<Liz>().minSpeed = GameGlobalState.lizMinSpeed;
    this.lizPrefab.GetComponent<Liz>().maxSpeed = GameGlobalState.lizMaxSpeed;
    GameObject lizClone = Instantiate(this.lizPrefab) as GameObject;
    if(!lizClone) {
      return 0;
    }

    lizClone.transform.position = new Vector2(xCreatePosition, yCreatePosition);
    return 1;
  }

  private bool ExistsStock() {
    return 0 < GameGlobalState.lizStock;
  }

  private float GetLizCreateInterval() {
    return Random.Range(GameGlobalState.lizCreateIntervalFrom, GameGlobalState.lizCreateIntervalTo);
  }
}
