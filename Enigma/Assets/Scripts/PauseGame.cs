using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool unpause = false;

    void Update() {
        Time.timeScale = 0;

        if (GameObject.Find("LevelComplete") && unpause) {
            Time.timeScale = 1;
            unpause = false;
        }

        if (GameObject.Find("GameOver") && unpause) {
            Time.timeScale = 1;
            unpause = false;
        }
    }
}
