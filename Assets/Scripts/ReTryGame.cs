using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReTryGame : MonoBehaviour {
  public void OnClick() {
    GameGlobalState.lizStock = GameGlobalState.settingLizStock;
    GameGlobalState.burretStock = GameGlobalState.settingBurretStock;

    SceneManager.LoadScene("Main");
  }
}
